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
    public partial class FrmCardList : Form
    {
        public FrmCardList()
        {
            InitializeComponent();
        }

        private void FrmCardList_Load(object sender, EventArgs e)
        {

        }
        private void btnImprimer_Click(object sender, EventArgs e)
        {
            //Todo impression des cartes schoolaires
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
