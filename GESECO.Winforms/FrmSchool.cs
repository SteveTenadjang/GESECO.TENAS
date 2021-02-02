using GESECO.BLL;
using GESECO.BO;
using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace GESECO.Winforms
{
    public partial class FrmSchool : Form
    {
        private EcoleBLO ecoleBLO;
        private string picture; 
        public FrmSchool()
        {
            InitializeComponent();
            ecoleBLO = new EcoleBLO(ConfigurationManager.AppSettings["DbFolder"]);
            picture = pbLogo.ImageLocation;

            //CreateFiliers();
            //CreateSpecialite();
        }

        private void CreateSpecialite()
        {
            SpecialiteBLO specialiteBLO = new SpecialiteBLO(ConfigurationManager.AppSettings["DbFolder"]);

            Specialite specialite = new Specialite("PAM", 2, "DEC");
            Specialite specialite1 = new Specialite("RSI", 2, "DEC");
            Specialite specialite2 = new Specialite("Genie Logiciel", 2, "BTS");
            Specialite specialite3 = new Specialite("Comptabilite", 2, "BTS");
            Specialite specialite4 = new Specialite("Software engeneering", 2, "HND");
            Specialite specialite5 = new Specialite("Accounting", 2, "HND");
            Specialite specialite6 = new Specialite("Marketing", 2, "BTS");
            Specialite specialite7 = new Specialite("Logistique", 2, "BTS");
            Specialite specialite8 = new Specialite("Computer Engeneering", 2, "HND");
            Specialite specialite9 = new Specialite("Mecanic Engeneering", 2, "HND");

            specialiteBLO.CreateSpecialite(specialite);
            specialiteBLO.CreateSpecialite(specialite1);
            specialiteBLO.CreateSpecialite(specialite2);
            specialiteBLO.CreateSpecialite(specialite3);
            specialiteBLO.CreateSpecialite(specialite4);
            specialiteBLO.CreateSpecialite(specialite5);
            specialiteBLO.CreateSpecialite(specialite6);
            specialiteBLO.CreateSpecialite(specialite7);
            specialiteBLO.CreateSpecialite(specialite8);
            specialiteBLO.CreateSpecialite(specialite9);

        }

        private void CreateFiliers()
        {
            FiliereBLO filiereBLO = new FiliereBLO(ConfigurationManager.AppSettings["DbFolder"]);

            Filiere filiere = new Filiere("TIC", 900000);
            Filiere filiere1 = new Filiere("BTS", 550000);
            Filiere filiere2 = new Filiere("HND", 450000);
            Filiere filiere3 = new Filiere("B-TECH", 650000);
            filiereBLO.CreateFiliere(filiere);
            filiereBLO.CreateFiliere(filiere1);
            filiereBLO.CreateFiliere(filiere2);
            filiereBLO.CreateFiliere(filiere3);
        }

        private void FrmSchool_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Ecole ecole = new Ecole(txtNom.Text,txtEmail.Text,long.Parse(txtContact.Text),txtAdresse.Text,File.ReadAllBytes(pbLogo.ImageLocation));
                ecoleBLO.CreateEcole(ecole);

                MessageBox.Show("Save Done!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNom.Text = string.Empty;
                pbLogo.ImageLocation = picture;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pbClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbLogo.ImageLocation = picture;
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choose a Picture";
            ofd.Filter = "Image files|*.jpg; *.jpeg; *.png; *.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
                pbLogo.ImageLocation = ofd.FileName;
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }
    }
}
