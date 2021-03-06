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
        private SpecialiteBLO specialiteBLO;
        public FrmPaiement()
        {
            InitializeComponent();
            etudiantBLO = new EtudiantBLO(ConfigurationManager.AppSettings["DbFolder"]);
            filiereBLO = new FiliereBLO(ConfigurationManager.AppSettings["DbFolder"]);
            specialiteBLO = new SpecialiteBLO(ConfigurationManager.AppSettings["DbFolder"]);
        }

        private void FrmPayement_Load(object sender, EventArgs e)
        {
            txtMatricule.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                List<Etudiant> etudiants = etudiantBLO.GetByID(txtMatricule.Text).ToList();

                if (double.Parse(txtAmount.Text) < 5000 || string.IsNullOrEmpty(txtAmount.Text)
                    || double.Parse(txtAmount.Text) > etudiants[0].SpecialiteE.FiliereS.Pension)
                {
                    if(etudiants[0].SpecialiteE.FiliereS.Pension == 0)
                    {
                        throw new Exception("Scolarite deja regler");                        
                    }
                    else
                        throw new Exception("Montant non valide");

                }
                Paiement payement = new Paiement(txtMatricule.Text, double.Parse(txtAmount.Text));
                PaiementBLO payementBLO = new PaiementBLO(ConfigurationManager.AppSettings["DbFolder"]);
                payementBLO.SavePaiement(payement);

                MessageBox.Show("Paiement Enregistrez!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatricule.Text = txtFiliere.Text = txtAmount.Text = txtNom.Text = txtPrenom.Text = txtUnPaid.Text = string.Empty;
                picBoxPhoto.Image = null;

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
                    List<Etudiant> etudiants = etudiantBLO.GetByID(txtMatricule.Text).ToList();

                    List<Specialite> specialites = specialiteBLO.GetBy(x => x.Nom.Equals(etudiants[0].SpecialiteE.Nom)).ToList();
                    txtFiliere.Text = specialites[0].Abreger;

                    txtNom.Text = etudiants[0].Nom.ToUpper();
                    txtPrenom.Text = etudiants[0].Prenom.ToUpper();
                    picBoxPhoto.Image = etudiants[0].Photo != null ? Image.FromStream(new MemoryStream(etudiants[0].Photo)) : null;

                    PaiementBLO paiementBLO = new PaiementBLO(ConfigurationManager.AppSettings["DbFolder"]);
                    var fees = paiementBLO.GetBy(x => x.Matricule == txtMatricule.Text).ToList();

                    double sommeFees = 0;

                    foreach(var f in fees)
                    {
                        sommeFees += f.AmountPaid;
                    }

                    etudiants[0].SpecialiteE.FiliereS.PayFees(sommeFees);

                    txtUnPaid.Text = $"{etudiants[0].SpecialiteE.FiliereS.Pension}Xaf";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
