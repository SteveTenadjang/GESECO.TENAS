using GESECO.BLL;
using GESECO.BO;
using GESECO.Winforms.Properties;
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

namespace GESECO.Winforms
{
    public partial class FrmHome : Form
    {
        private Color col1;
        private Color col2;
        FrmMenu frm;

        public FrmHome()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            //Ecole ee = new Ecole("IUC", "MyIUC@gmail.com", 653051037, "Logbessou", @"‪C:\Users\hp\OneDrive\Pictures\LogoTenas");
            //EcoleBLO eeblo = new EcoleBLO(ConfigurationManager.AppSettings["DbFolder"]);
            //eeblo.CreateCEcole(ee);
            frm = new FrmMenu();
        }
        void MenuLoad()
        {
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.pnlParent.Controls.Add(frm);
            this.pnlParent.Tag = frm;
            frm.BringToFront();
            frm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void OpenChildForm(Form childForm)
        {
            this.pnlParent.Controls.Clear();
            childForm.TopLevel = false;
            childForm.AutoScroll = true;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlParent.Controls.Add(childForm);
            this.pnlParent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnParametres_Click(object sender, EventArgs e)
        {
            FrmParametre frm = new FrmParametre();
            OpenChildForm(frm);
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            col1 = pnlParent.FillColor;
            col2 = pnlParent.FillColor2;
            MenuLoad();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            MenuLoad();
        }

        private void btnTheme_Click(object sender, EventArgs e)
        {
            if (btnTheme.Text == "Light Mode")
            {
                LightMode();
            }
            else
            {
                DarkMode();
            }
        }

        private void DarkMode()
        {
            BackColor = Color.DarkGray;
            pnlParent.FillColor = Color.DimGray;
            pnlParent.FillColor2 = Color.Black;
            pnlMenu.BackColor = Color.Black;
            this.ForeColor = btnParametres.FillColor = btnAide.FillColor = btnAboutUs.FillColor = Color.Black;
            pnlHead.BackColor = Color.Black;
            btnClose.FillColor = Color.Black;
            btnMaximize.FillColor = Color.Black;
            btnMinimized.FillColor = Color.Black;
            cbLanguage.BackColor = Color.Black;

            frm.btnMenu.FillColor = Color.CornflowerBlue;
            frm.btnAdminstration.FillColor2 = frm.btnAuthentification.FillColor2 = frm.btnCaisse.FillColor2 = Color.Black;
            frm.btnEtat.FillColor2 = frm.btnInfoEdit.FillColor2 = frm.btnInscription.FillColor2 = frm.btnListeEtudiant.FillColor2 = frm.btnPayement.FillColor2 = Color.Black;

            frm.pnlMenuBackground.FillColor = col1;
            frm.pnlMenuBackground.FillColor2 = col2;
            btnTheme.Text = "Light Mode";
            btnTheme.CustomImages.Image = Resources.icons8_sun_48;
        }

        private void LightMode()
        {
            BackColor = Color.White;
            pnlMenu.BackColor = Color.Teal;
            this.ForeColor = btnParametres.FillColor = btnAide.FillColor = btnAboutUs.FillColor = Color.Teal;
            pnlHead.BackColor = Color.Teal;
            btnClose.FillColor = Color.Teal;
            btnMaximize.FillColor = Color.Teal;
            btnMinimized.FillColor = Color.Teal;
            cbLanguage.BackColor = Color.Teal;

            frm.btnMenu.FillColor = Color.Teal;
            frm.btnAdminstration.FillColor2 = frm.btnAuthentification.FillColor2 = frm.btnCaisse.FillColor2 = Color.Teal;
            frm.btnEtat.FillColor2 = frm.btnInfoEdit.FillColor2 = frm.btnInscription.FillColor2 = frm.btnListeEtudiant.FillColor2 = frm.btnPayement.FillColor2 = Color.Teal;

            frm.pnlMenuBackground.FillColor2 = Color.DarkGray;
            frm.pnlMenuBackground.FillColor = Color.Teal;
            btnTheme.Text = "Dark Mode";
            btnTheme.CustomImages.Image = Resources.icons8_moon_symbol_60;
        }
    }
}
