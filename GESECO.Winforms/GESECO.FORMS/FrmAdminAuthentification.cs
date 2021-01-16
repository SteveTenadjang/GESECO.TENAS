using GESECO.BLL;
using GESECO.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESECO.Winforms.GESECO.FORMS
{
    public partial class FrmAdminAuthentification : Form
    {
        public FrmAdminAuthentification()
        {
            InitializeComponent();
        }

        private void FrmAdminAuthentification_Load(object sender, EventArgs e)
        {
            txtEmail.Focus();
        }

        private void OpenChildForm(Form childForm)
        {
            //pnlBack.Controls.Clear();
            pictureBox1.Visible = false;
            childForm.TopLevel = false;
            childForm.AutoScroll = true;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlBack.Controls.Add(childForm);
            pnlBack.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConnexion_Click_1(object sender, EventArgs e)
        {
            try
            {
                if ((txtEmail.Text == "admin" || txtEmail.Text == "cass") && (txtPass.Text == "admin") || txtPass.Text == "cass")
                {
                    if (txtEmail.Text == "admin")
                    {
                        //Tdo close the authenfication form after signup
                        FrmAdminDashBoard frmAdminDashBoard = new FrmAdminDashBoard();
                        OpenChildForm(frmAdminDashBoard);
                    }
                    else
                    {
                        FrmCaissiere frmCaissiere = new FrmCaissiere();
                        OpenChildForm(frmCaissiere);
                    }
                }
                else
                    throw new KeyNotFoundException();

            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
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

        private void cbShowPass_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbShowPass.Checked == true)
                txtPass.UseSystemPasswordChar = false;
            else
                txtPass.UseSystemPasswordChar = true;
        }
    }
}
