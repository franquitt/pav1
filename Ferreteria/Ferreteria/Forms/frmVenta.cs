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

        private void cboCliente_KeyUp(object sender, KeyEventArgs e)
        {
            string aBuscar = cboCliente.Text;
            Helper.llenarCbo(cboCliente, Cliente.GetClientesByName(aBuscar), "fullname", "codigoCliente");
            cboCliente.Text = aBuscar;
            cboCliente.Select(aBuscar.Length, 0);
        }

        private void cboCuit_KeyUp(object sender, KeyEventArgs e)
        {
            string aBuscar = cboCuit.Text;
            Helper.llenarCbo(cboCuit, Cliente.GetClientesByName(aBuscar), "cuit", "codigoCliente");
            cboCuit.Text = aBuscar;
            cboCuit.Select(aBuscar.Length, 0);
        }

        private void cboProducto_KeyUp(object sender, KeyEventArgs e)
        {
            string aBuscar = cboProducto.Text;
            Helper.llenarCbo(cboProducto, Producto.GetAllProductosByName(aBuscar), "nombre", "codigoProducto");
            cboProducto.Text = aBuscar;
            cboProducto.Select(aBuscar.Length, 0);
        }
    }
}
