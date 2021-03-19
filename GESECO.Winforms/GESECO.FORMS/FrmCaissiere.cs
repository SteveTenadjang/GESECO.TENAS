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
            List<RecieptPrinting> items = new List<RecieptPrinting>();
            Paiement pp = dgvEtudiantInscrit.SelectedRows[0].DataBoundItem as Paiement;
            List<Etudiant> ee = etudiantBLO.GetByID(pp.Matricule).ToList();
            if (ee[0].SpecialiteE.FiliereS.Pension >= GetFees(ee[0].ID, pp.AmountPaid))
            {

                items.Add
                (
                    new RecieptPrinting
                    (
                        ee[0]?.ID,
                        ee[0]?.Nom,
                        ee[0]?.Prenom,
                        ee[0].Contact,
                        ee[0]?.Email,
                        ee[0]?.Photo,
                        ee[0]?.SpecialiteE.Nom,
                        pp.AmountPaid,
                        GetFees(ee[0].ID, pp.AmountPaid),
                        ee[0]?.SpecialiteE.FiliereS.EcoleF.UniversiteE.Nom,
                        ee[0]?.SpecialiteE.FiliereS.EcoleF.UniversiteE.Abreger,
                        ee[0]?.SpecialiteE.FiliereS.EcoleF.UniversiteE.Adresse,
                        ee[0]?.SpecialiteE.FiliereS.EcoleF.UniversiteE.Email,
                        ee[0].SpecialiteE.FiliereS.EcoleF.UniversiteE.Contact,
                        ee[0]?.SpecialiteE.FiliereS.EcoleF.UniversiteE.Logo
                    )
                );

                Form f = new FrmRecuPrint("RecieptPrint.rdlc", items);
                f.ShowDialog();

                DialogResult DR = MessageBox.Show("Operation complete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DR == DialogResult.Yes)
                {
                    paiementHistory.SaveToHistory(pp);
                    paiementBLO.CancelPaiement(pp);
                    RefreshDataGrid();
                }
            }
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

        private Paiement pp;
        private void btnImprimer_Click(object sender, EventArgs e)
        {
            try
            {
                List<RecieptPrinting> items = new List<RecieptPrinting>();
                pp = dgvEtudiantInscrit.SelectedRows[0].DataBoundItem as Paiement;
                var pph = paiementHistory.GetAllPaiements();

                if (pp == null)
                    throw new KeyNotFoundException("Une ligne doit etre choisi");

                List<Etudiant> ee = etudiantBLO.GetByID(pp.Matricule).ToList();

                if (ee[0].SpecialiteE.FiliereS.Pension >= GetFees(ee[0].ID, pp.AmountPaid))
                {
                    items.Add
                        (
                            new RecieptPrinting
                            (
                                ee[0]?.ID,
                                ee[0]?.Nom,
                                ee[0]?.Prenom,
                                ee[0].Contact,
                                ee[0]?.Email,
                                ee[0]?.Photo,
                                ee[0]?.SpecialiteE.Nom,
                                pp.AmountPaid,
                                GetFees(ee[0].ID, pp.AmountPaid)
                            //ee[0]?.SpecialiteE.FiliereS.EcoleF.UniversiteE.Nom,
                            //ee[0]?.SpecialiteE.FiliereS.EcoleF.UniversiteE.Abreger,
                            //ee[0]?.SpecialiteE.FiliereS.EcoleF.UniversiteE.Adresse,
                            //ee[0]?.SpecialiteE.FiliereS.EcoleF.UniversiteE.Email,
                            //ee[0].SpecialiteE.FiliereS.EcoleF.UniversiteE.Contact,
                            //ee[0]?.SpecialiteE.FiliereS.EcoleF.UniversiteE.Logo
                            )
                        );

                    Form f = new FrmRecuPrint("RecieptPrint.rdlc", items);
                    f.WindowState = FormWindowState.Maximized;
                    f.FormClosed += F_FormClosed;
                    f.Show();
                }
                else
                {
                    DialogResult DR = MessageBox.Show("Pension deja Regler! \n\n Souhaite vous annuler le paiement?",
                                    "Pension regler",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Warning
                                    );

                    if(DR == DialogResult.Yes)
                        paiementBLO.CancelPaiement(pp);

                    RefreshDataGrid();
                }
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

            for(int i=0; i<pph.Count; i++)
                amountPaid += pph[i].AmountPaid;

            var etudiants = etudiantBLO.GetByID(matricule).ToList();
            double toPay = etudiants[0].SpecialiteE.FiliereS.Pension;
            return toPay-amountPaid;
        }
    }
}
