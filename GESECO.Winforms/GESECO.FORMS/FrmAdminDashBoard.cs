using GESECO.Winforms.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESECO.Winforms.GESECO.FORMS
{
    public partial class FrmAdminDashBoard : Form
    {
        public FrmAdminDashBoard()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void OpenChildForm(Form childForm)
        {
            //pnlBack.Controls.Clear();
            childForm.TopLevel = false;
            childForm.AutoScroll = true;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlBack.Controls.Add(childForm);
            pnlBack.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void bntClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlHead_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnTheme_Click(object sender, EventArgs e)
        {
            if(btnTheme.Text == "Light Mode")
            {
                pnlHead.BackColor = Color.Black;
                pnlBack.FillColor = Color.Gray;
                pnlBack.FillColor2 = Color.Black;
                btnAjoutEtudiant.FillColor = btnAjoutMembre.FillColor = btnListeEtudiant.FillColor = btnPayement.FillColor = Color.Black;
                btnCarte.FillColor = btnCertificate.FillColor = groupBox.CustomBorderColor = Color.Black;
                btnTheme.Text = "Dark Mode";
                btnTheme.CustomImages.Image = Resources.icons8_moon_symbol_60;
                groupBox.FillColor = Color.Gray;
                btnHeader.FillColor = Color.Black;
                btnHeader.FillColor2 = Color.Black;
                btnHeader.FillColor3 = Color.Black;
                btnHeader.FillColor4 = Color.Gray;
                gnSeperator.FillColor = Color.Black;
            }
            else
            {
                pnlHead.BackColor = Color.Brown;
                pnlBack.FillColor = Color.White;
                pnlBack.FillColor2 = Color.White;
                btnAjoutEtudiant.FillColor = btnAjoutMembre.FillColor = btnListeEtudiant.FillColor = btnPayement.FillColor = Color.Brown;
                btnCarte.FillColor = btnCertificate.FillColor = groupBox.CustomBorderColor = Color.Brown;
                btnTheme.Text = "Light Mode";
                btnTheme.CustomImages.Image = Resources.icons8_sun_48;
                groupBox.FillColor = Color.White;
                btnHeader.FillColor = Color.Brown;
                btnHeader.FillColor2 = Color.Brown;
                btnHeader.FillColor3 = Color.Brown;
                btnHeader.FillColor4 = Color.Brown;
                gnSeperator.FillColor = Color.Brown;
            }
        }

        private void btnPayement_Click_1(object sender, EventArgs e)
        {
            FrmPaiement frm = new FrmPaiement();
            OpenChildForm(frm);
        }

        private void btnAjoutMembre_Click_1(object sender, EventArgs e)
        {
            FrmAddMember frm = new FrmAddMember();
            OpenChildForm(frm);
        }

        private void btnAjoutEtudiant_Click(object sender, EventArgs e)
        {
            FrmInscription frm = new FrmInscription();
            OpenChildForm(frm);
        }

        private void btnListeEtudiant_Click_1(object sender, EventArgs e)
        {
            FrmListEtudiant frm = new FrmListEtudiant();
            OpenChildForm(frm);
        }

        private void btnCertificate_Click_1(object sender, EventArgs e)
        {
            FrmCertificateList frm = new FrmCertificateList();
            OpenChildForm(frm);
        }

        private void btnCarte_Click_1(object sender, EventArgs e)
        {
            FrmCardList frm = new FrmCardList();
            OpenChildForm(frm);
        }
    }
}
