using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ferreteria.DS_top10TableAdapters;
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
            var myTableAdapter = new PRODUCTOSTableAdapter();
            myTableAdapter.Fill(myDataTable);
            var rds = new ReportDataSource("DataSet1", myDataTable as DataTable);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
