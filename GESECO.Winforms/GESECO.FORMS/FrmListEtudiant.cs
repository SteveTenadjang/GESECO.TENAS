using _GESECO.BLL;
using _GESECO.BO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace GESECO.Winforms.GESECO.FORMS
{
    public partial class FrmListEtudiant : Form
    {
        private EtudiantBLO etudiantBLO;
        public FrmListEtudiant()
        {
            InitializeComponent();
            etudiantBLO = new EtudiantBLO(ConfigurationManager.AppSettings["DbFolder"]);
            dgvEtudiantInscrit.AutoGenerateColumns = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvEtudiantInscrit.DataSource = null;
            var lists = etudiantBLO.GetAllEtudiants().ToList();

            List<Etudiant> seen = new List<Etudiant>();
            foreach (Etudiant ee in lists)
            {
                if (
                    ee.Nom.ToLower().Contains(tbSearch.Text.ToLower()) ||
                    ee.Prenom.ToLower().Contains(tbSearch.Text.ToLower()) ||
                    ee.Contact.ToString().Contains(tbSearch.Text.ToLower())
                    )
                {
                    seen.Add(ee);
                }
            }
            dgvEtudiantInscrit.DataSource = seen;
        }

        private void FrmListEtudiant_Load(object sender, EventArgs e)
        {
            dgvEtudiantInscrit.DataSource = null;
            dgvEtudiantInscrit.DataSource = etudiantBLO.GetAllEtudiants().ToList();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
