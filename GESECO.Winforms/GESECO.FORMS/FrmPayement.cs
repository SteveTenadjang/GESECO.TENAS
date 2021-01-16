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
    public partial class FrmPayement : Form
    {
        public FrmPayement()
        {
            InitializeComponent();
        }

        private void FrmPayement_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(txtAmount.Text) < 5000 || string.IsNullOrEmpty(txtAmount.Text))
                    throw new Exception("Viellez entrez un montant > 5000");

                Payement payement = new Payement(txtMatricule.Text,txtNom.Text,txtPrenom.Text, txtFiliere.Text, double.Parse(txtAmount.Text));
                PayementBLO payementBLO = new PayementBLO(ConfigurationManager.AppSettings["DbFolder"]);
                payementBLO.CreatePayement(payement);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }
    }
}
