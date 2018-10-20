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

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
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
            Helper.llenarCboBuscador(cboProducto, Producto.GetAllProductosByName(txtBusquedaProducto.Text), "nombre", "codigoProducto");
        }

        private void txtBusquedaCliente_TextChanged(object sender, EventArgs e)
        {
            DataTable t = Cliente.GetClientesByName(txtBusquedaCliente.Text, true);
            Helper.llenarCboBuscador(cboCliente, t, "fullname", "codigoCliente");
            Helper.llenarCbo(cboCuit, t, "cuit", "codigoCliente");
        }

        private void txtBusquedaCuit_TextChanged(object sender, EventArgs e)
        {
            DataTable t = Cliente.GetClientesByName(txtBusquedaCuit.Text, false);
            Helper.llenarCboBuscador(cboCuit, t, "cuit", "codigoCliente");
            Helper.llenarCbo(cboCliente, t, "fullname", "codigoCliente");
        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cboCuit.SelectedIndex = cboCliente.SelectedIndex;
            }
            catch { }
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
            Cliente cliente;
            Empleado vendedor;
            TipoFactura tipoFactura;

            if (cboVendedor.SelectedValue != null)
            {
                vendedor = new Empleado((int)cboVendedor.SelectedValue);
            } else
            {
                MessageBox.Show("Debes elegir un vendedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboVendedor.Focus();
                return;
            }

            if (cboTipoFactura.SelectedValue != null)
            {
                tipoFactura = new TipoFactura((int)cboTipoFactura.SelectedValue);
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
                    cliente = new Cliente((int)cboCliente.SelectedValue);
                } else
                {
                    cliente = new Cliente((int)cboCuit.SelectedValue);
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

            string selectConditions = "";
            string updatesQ = "";
            int[] stockAlcanzado = new int[gridProductos.RowCount];
            string detallesValues = "";

            for (int i = 0; i < gridProductos.RowCount; i++)
            {
                productos[i] = new Producto((int)gridProductos.Rows[i].Cells[0].Value);
                cantidades[i] = int.Parse(gridProductos.Rows[i].Cells[2].Value.ToString());
                Lote[] lotes = Lote.getAllLotesObjectsByProduct(productos[i].codigoProducto);

                int[] stockNuevos = new int[lotes.Length];
                int index = 0;
                stockAlcanzado[i] = 0;
                for (index=0; index < lotes.Length; index++)
                {
                    if (stockAlcanzado[i] + lotes[index].stockActual <= cantidades[i])//le tengo que sacar el stock completo!
                    {
                        stockNuevos[index] = 0;
                        stockAlcanzado[i] += lotes[index].stockActual;
                    }else{
                        stockNuevos[index] = lotes[index].stockActual - (cantidades[i]- stockAlcanzado[i]);//a lo que tenia le saco lo que me hace falta nomas
                        stockAlcanzado[i] = cantidades[i];
                    }
                    if (selectConditions.Equals(""))
                        selectConditions += "numeroLote = " + lotes[index].nroLote;
                    else
                        selectConditions += " OR numeroLote = " + lotes[index].nroLote;
                    updatesQ += "\n UPDATE LOTES SET stockActual = " + stockNuevos[index] + " WHERE numeroLote = " + lotes[index].nroLote+";";
                    if (stockAlcanzado[i] != 0)
                    {
                        if (!detallesValues.Equals(""))
                            detallesValues += ", ";
                        detallesValues += "("+ lotes[index].nroLote + ", @@IDENTITY, "+ stockAlcanzado[i] + ", '"+ productos[i].precio+ "')";
                    }
                    if (stockAlcanzado[i] == cantidades[i])//si ya obtuve el stock que queria cortar
                        break;
                }
                
            }
            string laTransact = "SET TRANSACTION ISOLATION LEVEL SERIALIZABLE; " +
                "\n BEGIN TRANSACTION;" +
                "\n begin try " +
                "\n SELECT stockActual FROM LOTES WHERE " + selectConditions+";"+ updatesQ;
            

            if (productos.Length == 0)
            {
                MessageBox.Show("Debes cargar productos a la lista para poder continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string ahora = DateTime.Today.ToString("yyyy-MM-dd");
            laTransact += "\n INSERT INTO VENTAS(tipoFactura, vendedor, cliente, fecha, activo) VALUES("+tipoFactura.codigoTipo+", "+vendedor.legajo+", "+cliente.codigoCliente+", '"+ ahora + "', 1);";
            laTransact += "\nINSERT INTO DETALLE_VENTA(numeroLote, numeroVenta, cantidad, precioVenta) VALUES " + detallesValues;
            laTransact += "\nCOMMIT TRANSACTION;\n end try";
            laTransact += "\n begin catch" +
                "\n rollback transaction" +
                "\n raiserror('Error generando venta', 16, 1)" +                  
                "\n end catch";
            Console.WriteLine(laTransact);
            try
            {
                BDHelper.ExcecuteSQL(laTransact);
                MessageBox.Show("Venta confirmada", "Genial!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Hubo un problema generando la venta", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
