using _GESECO.BLL;
using _GESECO.BO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GESECO.Winforms.GESECO.FORMS
{
    public partial class FrmPaiement : Form
    {
        private EtudiantBLO etudiantBLO;
        private FiliereBLO filiereBLO;
        public FrmPaiement()
        {
            InitializeComponent();
            etudiantBLO = new EtudiantBLO(ConfigurationManager.AppSettings["DbFolder"]);
            filiereBLO = new FiliereBLO(ConfigurationManager.AppSettings["DbFolder"]);
        }

        private void FrmPayement_Load(object sender, EventArgs e)
        {
            txtMatricule.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(txtAmount.Text) < 5000 || string.IsNullOrEmpty(txtAmount.Text))
                    throw new Exception("Viellez entrez un montant > 5000");

                Paiement payement = new Paiement(txtMatricule.Text, double.Parse(txtAmount.Text));
                PaiementBLO payementBLO = new PaiementBLO(ConfigurationManager.AppSettings["DbFolder"]);
                payementBLO.SavePaiement(payement);

                MessageBox.Show("Paiement Enregistrez!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatricule.Text = txtFiliere.Text = txtAmount.Text = txtNom.Text = txtPrenom.Text = txtUnPaid.Text = string.Empty;
                picBoxPhoto.ImageLocation = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtMatricule_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (etudiantBLO.GetByID(txtMatricule.Text).Count() != 0)
                {
                    //Func<FiliereBLO, double> predicate;

                    Filiere f = new Filiere();
                    List<Etudiant> etudiants = etudiantBLO.GetByID(txtMatricule.Text).ToList();
                    txtFiliere.Text = etudiants[0].Specialite[0].ToString().ToUpper();
                    txtNom.Text = etudiants[0].Nom.ToUpper();
                    txtPrenom.Text = etudiants[0].Prenom.ToUpper();
                    picBoxPhoto.Image = etudiants[0].Photo != null ? Image.FromStream(new MemoryStream(etudiants[0].Photo)) : null;
                    txtUnPaid.Text =$"900000 xaf";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
