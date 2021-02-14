using _GESECO.BLL;
using _GESECO.BO;
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

            CreateFiliers();
            CreateSpecialite();
        }

        private void CreateSpecialite()
        {
            SpecialiteBLO specialiteBLO = new SpecialiteBLO(ConfigurationManager.AppSettings["DbFolder"]);

            Specialite specialite = new Specialite("Programmation et Application Mobile","PAM");
            Specialite specialite1 = new Specialite("Reseau et Securite Informatique","RSI");
            Specialite specialite2 = new Specialite("Genie Logiciel","GL");
            Specialite specialite3 = new Specialite("Comptabilite","COMP");
            Specialite specialite4 = new Specialite("Software Engeneering","SE");
            Specialite specialite5 = new Specialite("Accounting","ACC");
            Specialite specialite6 = new Specialite("Marketing","MK");
            Specialite specialite7 = new Specialite("Logistique","LG");
            Specialite specialite8 = new Specialite("Computer Engeneering","CE");
            Specialite specialite9 = new Specialite("Mecanic Engeneering","ME");

            specialiteBLO.AddSpecialite(specialite);
            specialiteBLO.AddSpecialite(specialite1);
            specialiteBLO.AddSpecialite(specialite2);
            specialiteBLO.AddSpecialite(specialite3);
            specialiteBLO.AddSpecialite(specialite4);
            specialiteBLO.AddSpecialite(specialite5);
            specialiteBLO.AddSpecialite(specialite6);
            specialiteBLO.AddSpecialite(specialite7);
            specialiteBLO.AddSpecialite(specialite8);
            specialiteBLO.AddSpecialite(specialite9);

        }

        private void CreateFiliers()
        {
            FiliereBLO filiereBLO = new FiliereBLO(ConfigurationManager.AppSettings["DbFolder"]);

            Filiere filiere = new Filiere("TI01", "Tenchnologie de l'Information et de la Communication", "TIC", 900000, "Diplome : DEC Durrer 2Ans");
            Filiere filiere1 = new Filiere("BTS", "Bachelor", "BTS", 450000, "Diplome : BTS Durrer 2Ans");
            Filiere filiere2 = new Filiere("HND", "Higher National Degree ", "HND", 900000, "Diplome : HND Durrer 2Ans");
            
            filiereBLO.AddFiliere(filiere);
            filiereBLO.AddFiliere(filiere1);
            filiereBLO.AddFiliere(filiere2);
        }

        private void FrmSchool_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Ecole ecole = new Ecole(txtID.Text,txtNom.Text,txtAbreger.Text,txtEmail.Text,txtAdresse.Text,long.Parse(txtContact.Text),File.ReadAllBytes(pbLogo.ImageLocation));
                ecoleBLO.AddEcole(ecole);

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
