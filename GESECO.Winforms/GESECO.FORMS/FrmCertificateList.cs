using System;
using System.Windows.Forms;

namespace GESECO.Winforms.GESECO.FORMS
{
    public partial class FrmCertificateList : Form
    {
        public FrmCertificateList()
        {
            InitializeComponent();
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            //Todo gere l'impression des certificates de scholarite
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCertificateList_Load(object sender, EventArgs e)
        {
            //Todo gere le datagridview a parti d'ici
        }
    }
}
