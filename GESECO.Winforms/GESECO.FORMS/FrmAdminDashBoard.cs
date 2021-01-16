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
    public partial class FrmAdminDashBoard : Form
    {
        public FrmAdminDashBoard()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnPayement_Click(object sender, EventArgs e)
        {
            FrmPayement frm = new FrmPayement();
            OpenChildForm(frm);
        }

        private void btnAjoutEtudiant_Click(object sender, EventArgs e)
        {
            FrmInscription frm = new FrmInscription();
            OpenChildForm(frm);
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

        private void FrmAdminDashBoard_Load(object sender, EventArgs e)
        {

        }

        private void btnCertificate_Click(object sender, EventArgs e)
        {
            FrmCertificateList frm = new FrmCertificateList();
            OpenChildForm(frm);
        }

        private void btnCarte_Click(object sender, EventArgs e)
        {
            FrmCardList frm = new FrmCardList();
            OpenChildForm(frm);
        }

        private void btnAjoutMembre_Click(object sender, EventArgs e)
        {
            FrmAddMember frm = new FrmAddMember();
            OpenChildForm(frm);
        }
    }
}
