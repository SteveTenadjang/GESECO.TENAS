using _GESECO.BLL;
using _GESECO.BO;
using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GESECO.Winforms.GESECO.FORMS
{
    public partial class FrmAddMember : Form
    {
        private Action callback;
        private AdminBLO adminBLO;
        private Admin oldAdmin = null;
        private Image img;

        public FrmAddMember()
        {
            InitializeComponent();
            adminBLO = new AdminBLO(ConfigurationManager.AppSettings["DbFolder"]);
        }
        public FrmAddMember(Action callback) : this()
        {
            this.callback = callback;
        }
        public FrmAddMember(Admin admin, Action callback) : this(callback)
        {
            this.oldAdmin = admin;
            txtNom.Text = admin.Nom;
            txtPrenom.Text = admin.Prenom;
            txtEmail.Text = admin.Email;
            txtLieu.Text = admin.LieuNaissance;
            txtAdresse.Text = admin.Adresse;
            txtTel.Text = admin.Contact.ToString();
            pbInscription.Image = admin.Photo != null ? Image.FromStream(new MemoryStream(admin.Photo)) : null;
            if (admin.Sexe == rbMale.Text)
                rbMale.Checked = true;
            else if (admin.Sexe == rbFemale.Text)
                rbMale.Checked = true;

            DatePicker.Value = DateTime.Parse(admin.DateNaissance.ToString());
            txtPoste.Text = admin.Poste;
        }
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                checkForm();
                string sex = (rbMale.Checked) ? rbMale.Text : (rbFemale.Checked) ? rbFemale.Text : null;
                string matricule = $"Admin00{adminBLO.CountAdmin()+1}";
                Admin newAdmin = new Admin(
                                matricule,
                                txtNom.Text,
                                txtPrenom.Text,
                                DateTime.Parse(DatePicker.Value.ToShortDateString()),
                                long.Parse(txtTel.Text),
                                txtLieu.Text,
                                sex,
                                txtEmail.Text,
                                txtAdresse.Text,
                                !string.IsNullOrEmpty(pbInscription.ImageLocation) ? File.ReadAllBytes(pbInscription.ImageLocation) : this.oldAdmin?.Photo,
                                txtPoste.Text
                            );

                if (this.oldAdmin == null)
                    adminBLO.AddAdmin(newAdmin);
                else
                    adminBLO.EditAdmin(oldAdmin,newAdmin);

                MessageBox.Show(
                    "Inscription Effectuer",
                    "Confirmation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );

                if (callback != null)
                    callback();

                if (oldAdmin != null)
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
                txtPoste.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void FrmAddMember_Load(object sender, EventArgs e)
        {
            img = pbInscription.Image;
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
            txtPoste.FillColor = Color.White;


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
            if (string.IsNullOrWhiteSpace(txtPoste.Text))
            {
                text += "- Poste can't be empty !\n";
                txtPoste.FillColor = Color.LightPink;
            }
            if (DatePicker.Value.Year >= DateTime.Now.Year)
            {
                text += "- Please take a look at Date of birth!\n";
                lblBornON.BackColor = Color.LightPink;
            }
            if (!string.IsNullOrEmpty(text))
                throw new TypingException(text);
        }
        private void pbInscription_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choose a Picture";
            ofd.Filter = "Image files|*.jpg; *.jpeg; *.png; *.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
                pbInscription.ImageLocation = ofd.FileName;
        }
        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }
        private void picClose_Click(object sender, EventArgs e)
        {
            pbInscription.Image = img;
        }
    }
}
