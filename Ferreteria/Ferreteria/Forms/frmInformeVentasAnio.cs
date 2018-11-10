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
using Ferreteria.Datasets.DS_VentasTableAdapters;
using Microsoft.Reporting.WinForms;

namespace Ferreteria.Forms
{
    public partial class frmInformeVentasAnio : Form
    {
        public frmInformeVentasAnio()
        {
            InitializeComponent();
        }

        private void frmVentasAnio_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            int cant;
            cant = Convert.ToInt32(txtAnio.Text);
            var myDataTable = new DS_Ventas.VENTASDataTable();
            var myTableAdapter = new VENTASTableAdapter();
            myTableAdapter.Fill(myDataTable, cant);
            var rds = new ReportDataSource("DataSet1", myDataTable as DataTable);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
