using GESECO.BLL;
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
    public partial class FrmAutentificationEtudiant : Form
    {
        private EtudiantBLO etudiantBLO;

        public FrmAutentificationEtudiant()
        {
            InitializeComponent();
            etudiantBLO = new EtudiantBLO(ConfigurationManager.AppSettings["dbFolder"]);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                //todo check autentification
                if (etudiantBLO.GetByMatricule(tbMatricule.Text).Count() == 0 && 
                    tbPassword.Text == tbMatricule.Text 
                    )
                {
                    //FrmMenu frm = new FrmMenu();
                    //frm.EtudiantMenu();
                    //FrmMenu frmMenu = new FrmMenu();
                    //frmMenu.btnAdminstration.Enabled = false;
                    //frmMenu.btnCaisse.Enabled = false;
                    //frmMenu.btnListeDesEtudiant.Enabled = false;
                    //frmMenu.btnInscription.Enabled = false;
                    //frm.OpenChildForm(frmMenu);
                    ////frmMenu.Show();
                    this.Close();
                }
                else
                    throw new KeyNotFoundException("Matricule non reconnu");
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }

            catch (Exception ex)
            {
                ex.WriteToFile();
                MessageBox.Show("An error occured please try again later",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked == true)
                tbPassword.UseSystemPasswordChar = false;
            else
                tbPassword.UseSystemPasswordChar = true;

        }
    }
}
