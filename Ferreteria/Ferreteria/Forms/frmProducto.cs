using System;
using System.Windows.Forms;
using Ferreteria.Models;

namespace Ferreteria.Forms
{
    public partial class frmProducto : Form
    {
        int id = 0;
        frmProductos formProductos = null;
        bool editMode = false;
        Producto producto = null;

        //inicializa el formulario con los datos pasados como parametro
        public frmProducto(int id, frmProductos productos, bool editMode)
        {
            this.id = id;
            this.formProductos = productos;
            this. editMode = editMode;
            InitializeComponent();
        }

        //Cuando carga el formulario rellena los campos con los datos del producto a editar si se esta editando
        //Caso contrario se desactiva el boton para dar de baja
        private void frmProducto_Load(object sender, EventArgs e)
        {
            Helper.llenarCbo(cboClasificacion, Clasificacion.GetAllClasificaciones(), "nombre", "codigoClasificacion");

            if (editMode)
            {
                producto = new Producto(id);
                txtNombreProducto.Text = producto.nombre;
                txtPrecioProducto.Text = producto.precio.ToString();
                txtDescripcionProducto.Text = producto.descripcion;
                this.Text += " - Id: " + producto.codigoProducto.ToString();
                btnSaveProducto.Text = "Guardar cambios";
                cboClasificacion.SelectedValue = producto.codigoClasificacion;
            }
            else
            {
                btnDeleteProducto.Visible = false;
            }
        }

        //Limpia los campos
        private void clean()
        {
            id = 0;
            txtNombreProducto.Text = "";
            txtPrecioProducto.Text = "";
            txtDescripcionProducto.Text = "";
        }

        //Chequea que todos los datos esten ingresados. Si lo estan procede a guardar el producto nuevo o a editarlo
        // si se estaba editando
        private void btnSaveProducto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreProducto.Text) ||
                string.IsNullOrEmpty(txtPrecioProducto.Text) ||
                string.IsNullOrEmpty(txtDescripcionProducto.Text) ||
                (cboClasificacion.SelectedIndex == -1))
            {
                MessageBox.Show("Debes completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!editMode)
            {
                new Producto(id, txtNombreProducto.Text, decimal.Parse(txtPrecioProducto.Text.Replace(".", ",")), txtDescripcionProducto.Text, (int)cboClasificacion.SelectedValue).Save();
                var confirmResult = MessageBox.Show("Se ha guardado con éxito el producto! Desea agregar otro?",
                    "Resultado", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    clean();
                }
                else
                {
                    formProductos.frmProductos_Load(null, null);
                    this.Close();
                }
            }
            else
            {
                producto.nombre = txtNombreProducto.Text;
                producto.descripcion = txtDescripcionProducto.Text;
                producto.precio = decimal.Parse(txtPrecioProducto.Text.Replace(".",","));
                producto.codigoClasificacion = (int)cboClasificacion.SelectedValue;
                producto.Save();
                formProductos.frmProductos_Load(null, null);
                this.Close();
            }
        }

        //Previa confirmacion del usuario, procede a dar de baja el producto
        private void btnDeleteProducto_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show("Esta seguro que desea deshabilitar este producto?",
                                         "Dar de baja!",
                                         MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    producto.available(false);
                    formProductos.frmProductos_Load(null, null);
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
