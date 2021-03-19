using _GESECO.BLL;
using Microsoft.Reporting.WinForms;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace GESECO.Winforms.GESECO.Reports
{
    public partial class FrmRecuPrint : Form
    {
        private object Items { get; set; }
        private object ReportPath { get; set; }

        public FrmRecuPrint()
        {
            InitializeComponent();
        }

        public FrmRecuPrint(string reportPath, object items): this()
        {
            ReportPath = reportPath;
            Items = items;
        }
        private void FrmRecuPrint_Load(object sender, EventArgs e)
        {

            this.reportViewer1.LocalReport.ReportPath = "GESECO.Prints\\RecieptPrint.rdlc";
            this.reportViewer1.LocalReport.DataSources.Add
                (
                    new ReportDataSource(
                    "DataSet1",
                    Items
                    )
                );
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 100;
            this.reportViewer1.RefreshReport();
        }
    }
}
