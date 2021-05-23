using _GESECO.BLL;
using _GESECO.BO;
using GESECO.Winforms.GESCO.PrintingClass;
using GESECO.Winforms.GESECO.Reports;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace GESECO.Winforms.GESECO.FORMS
{
    public partial class FrmCaissiere : Form
    {
        private PaiementBLO paiementBLO;
        private EtudiantBLO etudiantBLO;
        private PaiementHistoryBLO paiementHistory;
        public FrmCaissiere()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            dgvEtudiantInscrit.AutoGenerateColumns = false;
            paiementBLO = new PaiementBLO(ConfigurationManager.AppSettings["DbFolder"]);
            etudiantBLO = new EtudiantBLO(ConfigurationManager.AppSettings["DbFolder"]);
            paiementHistory = new PaiementHistoryBLO(ConfigurationManager.AppSettings["DbFolder"]);
        }

        private void dgvEtudiantInscrit_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnImprimer_Click(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmCaissiere_Load(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            dgvEtudiantInscrit.DataSource = null;
            var list = paiementBLO.GetAllPaiements().ToList();
            dgvEtudiantInscrit.DataSource = list;
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            try
            {
                List<RecieptPrinting> items = new List<RecieptPrinting>();
                Paiement pp = dgvEtudiantInscrit.SelectedRows[0].DataBoundItem as Paiement;
                //var pph = paiementHistory.GetAllPaiements();

                if (pp == null)
                    throw new KeyNotFoundException("Une ligne doit etre choisi");

                Etudiant seen = etudiantBLO.GetByID(pp.Matricule).First();

                items.Add
                        (
                            new RecieptPrinting
                            (
                                seen?.ID,
                                seen?.Nom,
                                seen?.Prenom,
                                seen.Contact,
                                seen?.Email,
                                seen?.Photo,
                                seen?.SpecialiteE.Nom,
                                pp.AmountPaid,
                                GetFees(seen.ID, pp.AmountPaid),
                                seen?.SpecialiteE.FiliereS.EcoleF?.UniversiteE.Nom,
                                seen?.SpecialiteE.FiliereS.EcoleF?.UniversiteE.Abreger,
                                seen?.SpecialiteE.FiliereS.EcoleF?.UniversiteE.Adresse,
                                seen?.SpecialiteE.FiliereS.EcoleF?.UniversiteE.Email,
                                seen?.SpecialiteE.FiliereS.EcoleF?.UniversiteE.Contact,
                                seen?.SpecialiteE.FiliereS.EcoleF?.UniversiteE.Logo
                            )
                        );

                Form f = new FrmRecuPrint("RecieptPrint.rdlc", items);
                f.WindowState = FormWindowState.Maximized;
                f.FormClosed += F_FormClosed;
                f.Show();
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void F_FormClosed(object sender, FormClosedEventArgs e)
        {
            Paiement pp = dgvEtudiantInscrit.SelectedRows[0].DataBoundItem as Paiement;
            DialogResult DR = MessageBox.Show("Operation complete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            {
                paiementHistory.SaveToHistory(pp);
                paiementBLO.CancelPaiement(pp);
            }
            RefreshDataGrid();
        }

        private double GetFees(string matricule, double currentPayement)
        {
            List<Paiement> pph = paiementHistory.GetBy(x => x.Matricule == matricule).ToList();
            double amountPaid = currentPayement;

            for (int i = 0; i < pph.Count; i++)
                amountPaid += pph[i].AmountPaid;

            var etudiants = etudiantBLO.GetByID(matricule).ToList();
            double toPay = etudiants[0].SpecialiteE.FiliereS.Pension;
            return toPay - amountPaid;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Paiement pp = dgvEtudiantInscrit.SelectedRows[0].DataBoundItem as Paiement;
            pp = dgvEtudiantInscrit.SelectedRows[0].DataBoundItem as Paiement;
            paiementBLO.CancelPaiement(pp);
            RefreshDataGrid();
        }
    }
}
