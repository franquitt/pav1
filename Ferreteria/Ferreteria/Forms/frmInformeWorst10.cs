using System;
using System.Data;
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
            string ahora = DateTime.Today.ToString("yyyy-MM-dd");
            string hace1Mes = DateTime.Today.AddMonths(-1).ToString("yyyy-MM-dd");
            txtDesde.Text = hace1Mes;
            txtHasta.Text = ahora;
            myTableAdapter.Fill(myDataTable, hace1Mes, ahora);
            var rds = new ReportDataSource("DS_worst10", myDataTable as DataTable);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DateTime fecha;
            if (DateTime.TryParse(txtDesde.Text, out fecha) & DateTime.TryParse(txtHasta.Text, out fecha))
            {
                var myDataTable = new DS_worst10.PRODUCTOSDataTable();
                var myTableAdapter = new PRODUCTOSTableAdapter();
                myTableAdapter.Fill(myDataTable, txtDesde.Text, txtHasta.Text);
                var rds = new ReportDataSource("DS_worst10", myDataTable as DataTable);

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
