using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ferreteria.Datasets;
using Ferreteria.Datasets.DS_worst10TableAdapters;
using Microsoft.Reporting.WinForms;

namespace Ferreteria.Forms
{
    public partial class frmInformeWorst10 : Form
    {
        public frmInformeWorst10()
        {
            InitializeComponent();
        }

        private void frmInformeWorst10_Load(object sender, EventArgs e)
        {

            var myDataTable = new DS_worst10.PRODUCTOSDataTable();
            var myTableAdapter = new PRODUCTOSTableAdapter();
            myTableAdapter.Fill(myDataTable);
            var rds = new ReportDataSource("DS_worst10", myDataTable as DataTable);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
