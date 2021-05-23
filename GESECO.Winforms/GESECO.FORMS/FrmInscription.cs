using _GESECO.BLL;
using _GESECO.BO;
using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace GESECO.Winforms
{
    public partial class FrmInscription : Form
    {
        private Action callback;
        private Etudiant oldEtudiant = null;
        private Image img;
        private SpecialiteBLO specialiteBLO;
        private FiliereBLO filiereBLO;

        public FrmInscription()
        {
            InitializeComponent();
            specialiteBLO = new SpecialiteBLO(ConfigurationManager.AppSettings["DbFolder"]);
            filiereBLO = new FiliereBLO(ConfigurationManager.AppSettings["DbFolder"]);
        }

        public FrmInscription(Action callback) : this()
        {
            this.callback = callback;
        }

        public FrmInscription(Etudiant etudiant, Action callback) : this(callback)
        {
            this.oldEtudiant = etudiant;
            txtNom.Text = etudiant.Nom;
            txtPrenom.Text = etudiant.Prenom;
            txtEmail.Text = etudiant.Email;
            txtLieu.Text = etudiant.LieuNaissance;
            txtAdresse.Text = etudiant.Adresse;
            txtTel.Text = etudiant.Contact.ToString();
            pbInscription.Image = etudiant.Photo != null ? Image.FromStream(new MemoryStream(etudiant.Photo)) : null;
            if (etudiant.Sexe == rbMale.Text)
                rbMale.Checked = true;
            else if (etudiant.Sexe == rbFemale.Text)
                rbMale.Checked = true;

            DatePicker.Value = DateTime.Parse(etudiant.DateNaissance.ToString());
            cbSpecialite.SelectedItem = etudiant.SpecialiteE;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pbInscription_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choose a Picture";
            ofd.Filter = "Image files|*.jpg; *.jpeg; *.png; *.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
                pbInscription.ImageLocation = ofd.FileName;
        }

        private void checkForm()
        {
            string text = string.Empty;
            txtNom.FillColor = Color.White;
            txtPrenom.FillColor = Color.White;
            txtLieu.FillColor = Color.White;
            txtEmail.FillColor = Color.White;
            txtTel.FillColor = Color.White;
            txtAdresse.FillColor = Color.White;
            lblSex.BackColor = Color.Transparent;
            lblBornON.BackColor = Color.Transparent;
            cbSpecialite.BackColor = Color.White;
            txtMDP.BackColor = Color.Transparent;



            if (string.IsNullOrWhiteSpace(txtNom.Text) || string.IsNullOrWhiteSpace(txtPrenom.Text))
            {
                text += "- FirstName or LastName can't be empty !\n";
                txtNom.FillColor = Color.LightPink;
                txtPrenom.FillColor = Color.LightPink;

            }

            if (rbMale.Checked == false && rbFemale.Checked == false)
            {
                text += "- Sex can't be empty !\n";
                lblSex.BackColor = Color.LightPink;
            }

            if (string.IsNullOrWhiteSpace(txtTel.Text))
            {
                text += "- Telephone can't be empty !\n";
                txtTel.FillColor = Color.LightPink;
            }
            if (string.IsNullOrWhiteSpace(txtLieu.Text))
            {
                text += "- Place of birth can't be empty !\n";
                txtLieu.FillColor = Color.LightPink;
            }
            if (string.IsNullOrWhiteSpace(txtMDP.Text))
            {
                text += "- Password can't be empty !\n";
                txtMDP.FillColor = Color.LightPink;
            }
            if (string.IsNullOrWhiteSpace(txtAdresse.Text))
            {
                text += "- Address can't be empty !\n";
                txtAdresse.FillColor = Color.LightPink;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                text += "- Email can't be empty !\n";
                txtEmail.FillColor = Color.LightPink;
            }
            if (DatePicker.Value.Year >= DateTime.Now.Year)
            {
                text += "- Please take a look at Date of birth!\n";
                lblBornON.BackColor = Color.LightPink;
            }
            if (cbSpecialite.SelectedItem == null)
            {
                text += "Please chose a course !\n";
                cbSpecialite.BackColor = Color.LightPink;
            }
            if (!string.IsNullOrEmpty(text))
                throw new TypingException(text);
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                EtudiantBLO blo = new EtudiantBLO(ConfigurationManager.AppSettings["DbFolder"]);
                checkForm();

                Specialite specialite = cbSpecialite.SelectedItem as Specialite;
                string abreger = (specialite != null) ? specialite.Abreger : null;

                string sex = (rbMale.Checked) ? rbMale.Text : (rbFemale.Checked) ? rbFemale.Text : null;
                string matricule = $"{abreger}{(blo.CountEtudiant() + 1).ToString().PadLeft(3,'0')}{sex.Substring(0, 1).ToUpper()}{DateTime.Now.Year.ToString().Substring(1,3)}";
                
                Etudiant newEtudiant = new Etudiant(
                        matricule,
                        txtNom.Text,
                        txtPrenom.Text,
                        DateTime.Parse(DatePicker.Value.ToShortDateString()),
                        long.Parse(txtTel.Text),
                        txtLieu.Text,
                        sex,
                        txtEmail.Text,
                        txtAdresse.Text,
                        !string.IsNullOrEmpty(pbInscription.ImageLocation) ? File.ReadAllBytes(pbInscription.ImageLocation) : this.oldEtudiant?.Photo,
                        cbSpecialite.SelectedItem as Specialite
                    );

                EtudiantBLO etudiantBLO = new EtudiantBLO(ConfigurationManager.AppSettings["DbFolder"]);

                if (this.oldEtudiant == null)
                    etudiantBLO.AddEtudiant(newEtudiant);
                else
                    etudiantBLO.EditEtudiant(oldEtudiant, newEtudiant);

                MessageBox.Show(
                    "Inscription Effectuer",
                    "Confirmation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );

                if (callback != null)
                    callback();

                if (oldEtudiant != null)
                    Close();

                txtNom.Clear();
                txtPrenom.Clear();
                txtEmail.Clear();
                txtLieu.Clear();
                txtAdresse.Clear();
                txtTel.Clear();
                pbInscription.Image = img;
                rbMale.Checked = false;
                rbFemale.Checked = false;
                DatePicker.Value = DateTime.Now;
                cbSpecialite.SelectedItem = null;
                txtMDP.Clear();
                MessageBox.Show($" votre matricule est : {newEtudiant.ID} ", "Inscription", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (TypingException ex)
            {
                MessageBox.Show(
                ex.Message,
                "Typing error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            pbInscription.Image = img;
        }

        private void FrmInscription_Load(object sender, EventArgs e)
        {
            txtNom.Focus();
            img = pbInscription.Image;

            List<Filiere> filiere = filiereBLO.GetAllFilieres().ToList();
            cbFiliere.DataSource = filiere;
            cbFiliere.DisplayMember = "Nom";

            List<Specialite> specialite = specialiteBLO.GetBy(x => x.FiliereS.Nom == cbFiliere.Text).ToList();
            cbSpecialite.DataSource = specialite;
            cbSpecialite.DisplayMember = "Nom";
        }

        private void cbPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPass.Checked == true)
                txtMDP.UseSystemPasswordChar = false;
            else
                txtMDP.UseSystemPasswordChar = true;
        }

        private void cbFiliere_SelectionChangeCommitted(object sender, EventArgs e)
        {
            List<Specialite> specialite = specialiteBLO.GetBy(x => x.FiliereS.Nom == cbFiliere.Text).ToList();
            cbSpecialite.DataSource = specialite;
            cbSpecialite.DisplayMember = "Nom";
        }
    }
}
