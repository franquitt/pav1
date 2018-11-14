using System;
using System.Data;
using System.Windows.Forms;
using Ferreteria.Models;
using Ferreteria.Forms;

namespace Ferreteria.Forms
{
    public partial class frmConsultarVenta : Form
    {
        public frmConsultarVenta()
        {
            InitializeComponent();
        }

        private void frmConsultarVenta_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Today;
            txtFechaDesde.Text = now.ToString("yyyy/MM/dd");
            txtFechaHasta.Text = now.ToString("yyyy/MM/dd");

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void txtBusquedaCliente_TextChanged(object sender, EventArgs e)
        {
            DataTable t = Cliente.GetClientesByName(txtBusquedaCliente.Text, true);
            Helper.llenarCboBuscador(cmbCliente, t, "fullname", "codigoCliente");
            Helper.llenarCbo(cmbCuit, t, "cuit", "codigoCliente");
        }

        private void txtCUIT_TextChanged(object sender, EventArgs e)
        {
            DataTable t = Cliente.GetClientesByName(txtCUIT.Text, false);
            Helper.llenarCboBuscador(cmbCuit, t, "cuit", "codigoCliente");
            Helper.llenarCbo(cmbCliente, t, "fullname", "codigoCliente");
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbCuit.SelectedIndex = cmbCliente.SelectedIndex;
            }
            catch { }
        }

        private void cmbCuit_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbCliente.SelectedIndex = cmbCuit.SelectedIndex;
            }
            catch { }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT VENTAS.numeroVenta, VENTAS.fecha, CLIENTES.apellido, CLIENTES.nombre, sum(DETALLE_VENTA.cantidad * DETALLE_VENTA.precioVenta) AS 'monto' " +
                "FROM VENTAS JOIN DETALLE_VENTA ON(DETALLE_VENTA.numeroVenta = VENTAS.numeroVenta) JOIN CLIENTES ON(CLIENTES.codigoCliente = VENTAS.cliente) ";

            if (!string.IsNullOrEmpty(txtFechaDesde.Text) || !string.IsNullOrEmpty(txtFechaHasta.Text) || !string.IsNullOrEmpty(cmbCliente.Text))
            {
                consulta += " WHERE";
                bool and = false;

                if (!string.IsNullOrEmpty(txtFechaDesde.Text) && !string.IsNullOrEmpty(txtFechaDesde.Text)) {
                    consulta += " fecha BETWEEN '" + txtFechaDesde.Text + "' AND '" + txtFechaHasta.Text + "'";
                    and = true;
                }
                if (!string.IsNullOrEmpty(cmbCliente.Text))
                {
                    if (and)
                    {
                        consulta += " AND";
                    }
                    consulta += " CLIENTES.codigoCliente = " + cmbCliente.SelectedValue;
                }
            }

            consulta += " GROUP BY VENTAS.numeroVenta, VENTAS.fecha, CLIENTES.apellido, CLIENTES.nombre";
            DataTable resultado = BDHelper.ConsultaSQL(consulta);
            dgvVentas.DataSource = resultado;
        }

        private void dgvVentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idVenta = Helper.getSelectedId(dgvVentas);
            new frmVenta(idVenta).Show();
        }
    }
}
