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
using Ferreteria.Datasets.DS_TopSellersTableAdapters;
using Ferreteria.Datasets.DS_top10TableAdapters;
using Microsoft.Reporting.WinForms;

namespace Ferreteria.Forms
{
    public partial class frmInformeTopSellers : Form
    {
        public frmInformeTopSellers()
        {
            InitializeComponent();
        }

        private void frmInformeTopSellers_Load(object sender, EventArgs e)
        {
            string ahora = DateTime.Today.ToString("yyyy-MM-dd");
            string hace1Mes = DateTime.Today.AddMonths(-1).ToString("yyyy-MM-dd");
            txtDesde.Text = hace1Mes;
            txtHasta.Text = ahora;
            var myDataTable = new DS_TopSellers.USUARIODataTable();
            var myTableAdapter = new USUARIOTableAdapter();
            myTableAdapter.Fill(myDataTable, hace1Mes, ahora);
            var rds = new ReportDataSource("DataSet1", myDataTable as DataTable);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fecha;
            if (DateTime.TryParse(txtDesde.Text, out fecha) & DateTime.TryParse(txtHasta.Text, out fecha))
            {
                var myDataTable = new DS_TopSellers.USUARIODataTable();
                var myTableAdapter = new USUARIOTableAdapter();
                myTableAdapter.Fill(myDataTable, txtDesde.Text, txtHasta.Text);
                var rds = new ReportDataSource("DataSet1", myDataTable as DataTable);

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("Debe completar los datos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
