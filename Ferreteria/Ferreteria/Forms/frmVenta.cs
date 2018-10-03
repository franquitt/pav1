using System;
using System.Data;
using System.Windows.Forms;
using Ferreteria.Models;

namespace Ferreteria.Forms
{
    public partial class frmVenta : Form
    {
        public frmVenta()
        {
            InitializeComponent();
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            Helper.llenarCbo(cboTipoFactura, TipoFactura.GetAllTipoFacturas(), "nombre", "codigoTipo");
            Helper.llenarCbo(cboVendedor, Empleado.GetAllEmployes(), "Nombre", "legajo");
            DateTime now = DateTime.Today;
            txtFecha.Text = now.ToString("dd/MM/yyyy");
        }
    }
}
