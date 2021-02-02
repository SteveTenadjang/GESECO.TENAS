using GESECO.BLL;
using GESECO.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESECO.Winforms.GESECO.FORMS
{
    public partial class FrmAuthentfication : Form
    {
        private EtudiantBLO etudiantBLO;
        public FrmAuthentfication()
        {
            InitializeComponent();
            etudiantBLO = new EtudiantBLO(ConfigurationManager.AppSettings["DbFolder"]);
        }

        private void btnSignIn_Click_1(object sender, EventArgs e)
        {
            try
            {
                List<Etudiant> seen = etudiantBLO.GetByMatricule(tbIdentifiant.Text).ToList();

                if (tbIdentifiant.Text.Equals(tbPassword.Text))
                {
                    switch (tbIdentifiant.Text.ToLower())
                    {
                        case "admin":
                            {
                                this.Hide();
                                FrmAdminDashBoard frm = new FrmAdminDashBoard();
                                frm.Show();
                            }
                            break;
                        case "cass":
                            {
                                this.Hide();
                                FrmCaissiere frmcase = new FrmCaissiere();
                                frmcase.Show();
                            }
                            break;
                        default:
                            break;
                    }

                }
                else
                    throw new KeyNotFoundException("Identifiant ou Password non reconnu!");

                if (etudiantBLO.GetByMatricule(tbIdentifiant.Text).Count() != 0 && tbIdentifiant.Text.Equals(tbPassword.Text))
                {
                    this.Hide();
                    FrmHome frm = new FrmHome();
                    frm.Show();
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
    }
}
