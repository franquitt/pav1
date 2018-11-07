using System;
using System.Data;
using System.Windows.Forms;
using Ferreteria.Datasets;
using Ferreteria.Datasets.DS_top10TableAdapters;
using Microsoft.Reporting.WinForms;

namespace Ferreteria.Forms
{
    public partial class frmInformeTop10 : Form
    {
        public frmInformeTop10()
        {
            InitializeComponent();
        }

        private void frmInformeTop10_Load(object sender, EventArgs e)
        {
            var myDataTable = new DS_top10.PRODUCTOSDataTable();
            var myTableAdapter = new PRODUCTOSTopTableAdapter();
            myTableAdapter.Fill(myDataTable);
            var rds = new ReportDataSource("DS_top10", myDataTable as DataTable);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
