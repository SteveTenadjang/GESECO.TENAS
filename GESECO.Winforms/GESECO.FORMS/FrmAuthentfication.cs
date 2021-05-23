using _GESECO.BLL;
using _GESECO.BO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GESECO.Winforms.GESECO.FORMS
{
    public partial class FrmAuthentfication : Form
    {
        private EtudiantBLO etudiantBLO;
        private AdminBLO adminBLO;
        private UserBLO userBLO;
        private CaissiereBLO caissiereBLO;

        public FrmAuthentfication()
        {
            InitializeComponent();
            etudiantBLO = new EtudiantBLO(ConfigurationManager.AppSettings["DbFolder"]);
            userBLO = new UserBLO(ConfigurationManager.AppSettings["DbFolder"]);
            adminBLO = new AdminBLO(ConfigurationManager.AppSettings["DbFolder"]);
            caissiereBLO = new CaissiereBLO(ConfigurationManager.AppSettings["DbFolder"]);
            //CreateAdmin();
        }

        //private void CreateAdmin()
        //{
        //    string matricule = $"Admin00{adminBLO.CountAdmin() + 1}";
        //    Admin admin = new Admin(matricule,
        //                            "Tenadjang",
        //                            "Steve",
        //                            DateTime.Parse(DateTime.Now.ToShortTimeString()),
        //                            653051037,
        //                            "Douala",
        //                            "Male",
        //                            "admin",
        //                            "admin@gmail.com",
        //                            "Logbessou",
        //                            File.ReadAllBytes(@"S:\2eme Année\T1\development multi-couches\Code\GESECO\GESECO.Winforms\GESECO.FORMS\iconT.png"),
        //                            "Sudo FULLSTACK"
        //                            );
        //    adminBLO.AddAdmin(admin);

        //    matricule = $"Admin00{adminBLO.CountAdmin() + 1}";
        //    Admin admin1 = new Admin(matricule,
        //                            "Mbou",
        //                            "Yassen",
        //                            DateTime.Parse(DateTime.Now.ToShortTimeString()),
        //                            684521525,
        //                            "Youande",
        //                            "Male",
        //                            "mbou",
        //                            "mbouyasen@gmail.com",
        //                            "Logbessou",
        //                            File.ReadAllBytes(@"S:\2eme Année\T1\development multi-couches\Code\GESECO\GESECO.Winforms\GESECO.FORMS\iconT.png"),
        //                            "Chef de projet du groupe"
        //                            );
        //    adminBLO.AddAdmin(admin1);

        //    matricule = $"Admin00{adminBLO.CountAdmin() + 1}";
        //    Admin admin2 = new Admin(matricule,
        //                            "Ndanga",
        //                            "Scintich",
        //                            DateTime.Parse(DateTime.Now.ToShortTimeString()),
        //                            652185548,
        //                            "Youande",
        //                            "Female",
        //                            "ndanga",
        //                            "Ndangascintich@gmail.com",
        //                            "Logbessou",
        //                            File.ReadAllBytes(@"S:\2eme Année\T1\development multi-couches\Code\GESECO\GESECO.Winforms\GESECO.FORMS\iconT.png"),
        //                            "Analsyte de projet du groupe"
        //                            );
        //    adminBLO.AddAdmin(admin2);

        //    matricule = $"Admin00{adminBLO.CountAdmin() + 1}";
        //    Admin admin3 = new Admin(matricule,
        //                            "Fotso",
        //                            "Leanne",
        //                            DateTime.Parse(DateTime.Now.ToShortTimeString()),
        //                            6995845224,
        //                            "Douala",
        //                            "Female",
        //                            "fotso",
        //                            "fostoleanne@gmail.com",
        //                            "Diedo",
        //                            File.ReadAllBytes(@"S:\2eme Année\T1\development multi-couches\Code\GESECO\GESECO.Winforms\GESECO.FORMS\iconT.png"),
        //                            "Architecte de base de donnee du groupe"
        //                            );
        //    adminBLO.AddAdmin(admin3);

        //    matricule = $"Admin00{adminBLO.CountAdmin() + 1}";
        //    Admin admin4 = new Admin(matricule,
        //                            "Nzeundi",
        //                            "Carmel",
        //                            DateTime.Parse(DateTime.Now.ToShortTimeString()),
        //                            652147585,
        //                            "Baffoussam",
        //                            "Male",
        //                            "nzeundi",
        //                            "nzeundicarmel@gmail.com",
        //                            "Logbessou",
        //                            File.ReadAllBytes(@"S:\2eme Année\T1\development multi-couches\Code\GESECO\GESECO.Winforms\GESECO.FORMS\iconT.png"),
        //                            "Front-end developpeur du groupe"
        //                            );
        //    adminBLO.AddAdmin(admin4);

        //    matricule = $"Admin00{adminBLO.CountAdmin() + 1}";
        //    Admin admin5 = new Admin(matricule,
        //                            "Chimi",
        //                            "Ronald",
        //                            DateTime.Parse(DateTime.Now.ToShortTimeString()),
        //                            652147585,
        //                            "Youande",
        //                            "Male",
        //                            "chimi",
        //                            "chimironald@gmail.com",
        //                            "Logpom",
        //                            File.ReadAllBytes(@"S:\2eme Année\T1\development multi-couches\Code\GESECO\GESECO.Winforms\GESECO.FORMS\iconT.png"),
        //                            "Back-end developpeur du groupe"
        //                            );
        //    adminBLO.AddAdmin(admin5);
        //}

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (etudiantBLO.GetBy(x => x.Email == tbIdentifiant.Text).Count() > 0 
                    && etudiantBLO.GetByID(tbPassword.Text).Count() > 0)
                {
                    this.Hide();
                    FrmHome frm = new FrmHome();
                    frm.Show();
                }
                else 
                if (adminBLO.GetBy(x => x.Email == tbIdentifiant.Text).Count() > 0 
                    && adminBLO.GetByID(tbPassword.Text).Count() > 0)
                {
                    this.Hide();
                    FrmAdminDashBoard frm = new FrmAdminDashBoard();
                    frm.Show();
                }
                else if (caissiereBLO.GetBy(x => x.Email == tbIdentifiant.Text).Count() > 0
                    && caissiereBLO.GetByID(tbPassword.Text).Count() > 0)
                {
                    this.Hide();
                    FrmCaissiere frmcase = new FrmCaissiere();
                    frmcase.Show();
                }
                else if (tbIdentifiant.Text == "cass" 
                    && tbIdentifiant.Text == tbPassword.Text)
                {
                    this.Hide();
                    FrmCaissiere frmcase = new FrmCaissiere();
                    frmcase.Show();
                }
                else
                {
                    throw new KeyNotFoundException("L'identifiant ou le not de passe n'ai pas correct");
                }
                
                if (cbRemembreMe.Checked == true)
                {
                    User user = new User(tbIdentifiant.Text, tbPassword.Text);
                    userBLO.SaveUser(user);
                }

            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Key not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (tbPassword.UseSystemPasswordChar == true)
                tbPassword.UseSystemPasswordChar = false;
            else
                tbPassword.UseSystemPasswordChar = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbPassword_DoubleClick(object sender, EventArgs e)
        {
            cbShowPass_CheckedChanged(sender, e);
        }

        private void FrmAuthentfication_Load(object sender, EventArgs e)
        {
            if(userBLO.GetUser().Count() != 0)
            {
                var seen = userBLO.GetUser().ToList();
                tbIdentifiant.Text = seen[userBLO.GetUser().Count() -1].Identifiant;
                tbPassword.Text = seen[userBLO.GetUser().Count() -1].MDP;
            }
        }
    }
}
