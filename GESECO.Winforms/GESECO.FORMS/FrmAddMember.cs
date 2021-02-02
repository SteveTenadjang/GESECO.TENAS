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
    public partial class FrmAddMember : Form
    {
        private AdminBLO adminBLO;
        public FrmAddMember()
        {
            InitializeComponent();
            adminBLO = new AdminBLO(ConfigurationManager.AppSettings["DbFolder"]);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            //Todo finir FrmAjouter membre et adapter le formulaire a la classe
        }
    }
}
