using System;
using System.Windows.Forms;
using Ferreteria.Models;

namespace Ferreteria.Forms
{
    public partial class frmProvProd : Form
    {
        int prod = 0;
        int prov = 0;
        frmProvsProds form = null;
        bool editMode = true;
        ProvXProd asociacion = null;

        public frmProvProd(int prod, int prov, frmProvsProds frm, bool edit)
        {
            this.prov = prov;
            this.prod = prod;
            this.form = frm;
            this.editMode = edit;
            InitializeComponent();
        }

        private void frmProvProd_Load(object sender, EventArgs e)
        {
            Helper.llenarCbo(cboProducto, Producto.GetNames(), "nombre", "codigoProducto");
            Helper.llenarCbo(cboProveedor, Proveedor.GetAllNames(), "fullname", "codigoProveedor");

            if (editMode)
            {
                asociacion = new ProvXProd(prod, prov);
                try
                {
                    cboProducto.SelectedValue = asociacion.prod;
                }
                catch
                {
                    cboProducto.SelectedIndex = -1;
                }
                try
                {
                    cboProveedor.SelectedValue = asociacion.prov;
                }
                catch
                {
                    cboProveedor.SelectedIndex = -1;
                }
                txtTiempo.Text = asociacion.tiempo.ToString();
                txtPrecio.Text = asociacion.precio.ToString();

                btnSaveAsociacion.Text = "Guardar cambios";
                Text = "Editando asociacion";
            }
            else
            {
                btnDeleteAsociacion.Visible = false;
            }
        }

        private void btnSaveAsociacion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrecio.Text) ||
                string.IsNullOrEmpty(txtTiempo.Text) ||
                (cboProveedor.SelectedIndex == -1) ||
                (cboProducto.SelectedIndex == -1))
            {
                MessageBox.Show("Debes completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!editMode)
            {
                new ProvXProd(int.Parse(cboProducto.SelectedValue.ToString()), int.Parse(cboProveedor.SelectedValue.ToString()), int.Parse(txtTiempo.Text), decimal.Parse(txtPrecio.Text.Replace(".", ","))).save(true);
                var confirmResult = MessageBox.Show("Se ha guardado con éxito la asociacion! Desea agregar otra?",
                    "Resultado", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    clean();
                }
                else
                {
                    form.frmProvsProds_Load(null, null);
                    this.Close();
                }
            }
            else
            {
                asociacion.prod = int.Parse(cboProducto.SelectedValue.ToString());
                asociacion.prov = int.Parse(cboProveedor.SelectedValue.ToString());
                asociacion.tiempo = int.Parse(txtTiempo.Text);
                asociacion.precio = decimal.Parse(txtPrecio.Text.Replace(".", ","));
                asociacion.save(false);
                form.frmProvsProds_Load(null, null);
                this.Close();
            }
        }

        private void btnDeleteAsociacion_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show("Esta seguro que desea eliminar esta asociacion?",
                                         "Dar de baja!",
                                         MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    asociacion.delete();
                    form.frmProvsProds_Load(null, null);
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK);
            }
        }

        //Limpia los campos
        private void clean()
        {
            prov = 0;
            prod = 0;
            cboProveedor.SelectedIndex = -1;
            cboProducto.SelectedIndex = -1;
            txtPrecio.Text = "";
            txtTiempo.Text = "";
        }

        private void txtBusquedaProducto_TextChanged(object sender, EventArgs e)
        {
            Helper.llenarCboBuscador(cboProducto, Producto.GetAllProductosByName(txtBusquedaProducto.Text), "nombre", "codigoProducto");
        }

        private void txtBusquedaProveedor_TextChanged(object sender, EventArgs e)
        {
            Helper.llenarCboBuscador(cboProveedor, Proveedor.GetAllProveedoresByName(txtBusquedaProveedor.Text), "fullname", "codigoProveedor");
        }
    }
}
