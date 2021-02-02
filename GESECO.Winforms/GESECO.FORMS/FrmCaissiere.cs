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
    public partial class FrmCaissiere : Form
    {
        public FrmCaissiere()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            dgvEtudiantInscrit.AutoGenerateColumns = false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //List<Recu> items = new List<Recu>();
            //Payement c = dgvEtudiantInscrit.SelectedRows[0].DataBoundItem as Payement;
            //items.Add
            //    (
            //        new Recu
            //        (
            //            c.Matricule,
            //            c.Course,
            //            c.AmountPaid.ToString()
            //        )
            //    );
            //Form f = new FrmRecu("RecuPrinting.rdlc", items);
            //f.Show();

        }

        private void dgvEtudiantInscrit_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1_CellDoubleClick(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
