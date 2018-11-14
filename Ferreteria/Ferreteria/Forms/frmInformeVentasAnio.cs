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

        //Al apretar el boton, relaciona el dataset con el reporte con el período de tiempo elegido como parámetro
        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (txtAnio.Text != "")
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
            else
            {
                MessageBox.Show("Debe ingresar un año", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
