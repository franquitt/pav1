using System;
using System.Data;
using System.Windows.Forms;
using Ferreteria.Models;

namespace Ferreteria.Forms
{
    public partial class frmVenta : Form
    {
        Producto productoElegido = null;

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

            txtCantidadProducto.TextChanged += new EventHandler(txtCantidadProducto_TextChanged);
            btnAgregarProducto.Enabled = false;
            lblTotalNeto.Visible = false;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            string total = "$" + ((decimal)productoElegido.precio * decimal.Parse(txtCantidadProducto.Text)).ToString();
            gridProductos.Rows.Add(productoElegido.codigoProducto, productoElegido.nombre, txtCantidadProducto.Text, "$" + productoElegido.precio, total);
            cboProducto.SelectedIndex = -1;
            txtCantidadProducto.Text = "0";
            lblPrecioUnitario.Text = "Precio unitario:";
            lblPrecioTotal.Text = "Precio total:";
            btnAgregarProducto.Enabled = false;
            lblTotalNeto.Text ="$" + CalcularTotal().ToString();
            lblTotalNeto.Visible = true;
        }

        private void txtCantidadProducto_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCantidadProducto.Text))
            {
                if (productoElegido != null)
                {
                    decimal total = (decimal)productoElegido.precio * decimal.Parse(txtCantidadProducto.Text);
                    lblPrecioTotal.Text = "Precio total: $" + total;
                    btnAgregarProducto.Enabled = true;
                }
            } else
            {
                lblPrecioTotal.Text = "Precio total:";
            }
        }

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                productoElegido = new Producto(int.Parse(cboProducto.SelectedValue.ToString()));
                lblPrecioUnitario.Text = "Precio unitario: $" + productoElegido.precio;
                lblPrecioTotal.Text = "Precio total:";
                txtCantidadProducto.Text = "0";
                lblStock.Text = "Stock: " + (productoElegido.stock.ToString());
            }
            catch { }
            btnAgregarProducto.Enabled = false;
        }

        private void txtBusquedaProducto_TextChanged(object sender, EventArgs e)
        {
            string aBuscar = txtBusquedaProducto.Text;
            cboProducto.DroppedDown = false;
            Helper.llenarCbo(cboProducto, Producto.GetAllProductosByName(aBuscar), "nombre", "codigoProducto");
            cboProducto.DroppedDown = true;
        }

        private void txtBusquedaCliente_TextChanged(object sender, EventArgs e)
        {
            string aBuscar = txtBusquedaCliente.Text;
            cboCliente.DroppedDown = false;
            DataTable t = Cliente.GetClientesByName(aBuscar, true);
            Helper.llenarCbo(cboCliente, t, "fullname", "codigoCliente");
            Helper.llenarCbo(cboCuit, t, "cuit", "codigoCliente");
            cboCliente.DroppedDown = true;
        }

        private void txtBusquedaCuit_TextChanged(object sender, EventArgs e)
        {
            string aBuscar = txtBusquedaCuit.Text;
            cboCuit.DroppedDown = false;
            DataTable t = Cliente.GetClientesByName(aBuscar, false);
            Helper.llenarCbo(cboCuit, t, "cuit", "codigoCliente");
            Helper.llenarCbo(cboCliente, t, "fullname", "codigoCliente");
            cboCuit.DroppedDown = true;
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            Form frmCliente = new frmCliente(0, null, false);
            frmCliente.Show();
        }

        private void btnQuitarProducto_Click(object sender, EventArgs e)
        {
            int index = -1;
            try
            {
                index = gridProductos.SelectedRows[0].Cells[0].RowIndex;
            }
            catch
            {
                try
                {
                    index = gridProductos.Rows[(int)gridProductos.SelectedCells[0].RowIndex].Cells[0].RowIndex;
                }
                catch
                {

                }
            }
            if (index > -1)
            {
                gridProductos.Rows.RemoveAt(index);
                lblTotalNeto.Text = "$" + CalcularTotal().ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {
            if (cboVendedor.SelectedValue != null)
            {
                Empleado vendedor = new Empleado((int)cboVendedor.SelectedValue);
            } else
            {
                MessageBox.Show("Debes elegir un vendedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboVendedor.Focus();
                return;
            }

            if (cboTipoFactura.SelectedValue != null)
            {
                TipoFactura tipoFactura = new TipoFactura((int)cboTipoFactura.SelectedValue);
            }
            else
            {
                MessageBox.Show("Debes elegir un tipo de factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTipoFactura.Focus();
                return;
            }

            if (cboCliente.SelectedValue != null && cboCuit.SelectedValue != null)
            {
                if (cboCliente.SelectedValue != null)
                {
                    Cliente cliente = new Cliente((int)cboCliente.SelectedValue);
                } else
                {
                    Cliente cliente = new Cliente((int)cboCuit.SelectedValue);
                }
            }
            else
            {
                MessageBox.Show("Debes elegir un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTipoFactura.Focus();
                return;
            }

            Producto[] productos = new Producto[gridProductos.RowCount];
            int[] cantidades = new int[gridProductos.RowCount];
            for (int i = 0; i < gridProductos.RowCount; i++)
            {
                productos[i] = new Producto((int)gridProductos.Rows[i].Cells[0].Value);
                cantidades[i] = int.Parse(gridProductos.Rows[i].Cells[2].Value.ToString());
            }

            if (productos.Length == 0)
            {
                MessageBox.Show("Debes cargar productos a la lista para poder continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private decimal CalcularTotal()
        {
            decimal total = 0;
            for (int i = 0; i < gridProductos.Rows.Count; i++)
            {
                total += Convert.ToDecimal((gridProductos.Rows[i].Cells[4].Value).ToString().Replace("$",""));
            }
            return total;
        }
    }
}
