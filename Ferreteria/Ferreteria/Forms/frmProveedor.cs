using System;
using System.Windows.Forms;
using Ferreteria.Models;

namespace Ferreteria.Forms
{
    public partial class frmProveedor : Form
    {
        int codigoProveedor = 0;
        frmProveedores form = null;
        bool editMode = true;
        Proveedor proveedor = null;

        //inicializa el formulario con los datos pasados como parametro
        public frmProveedor(int id, frmProveedores form, bool editMode)
        {
            InitializeComponent();
            this.form = form;
            this.editMode = editMode;
            this.codigoProveedor = id;
        }

        //Cuando carga el formulario rellena los campos con los datos del proveedor a editar si se esta editando
        //Caso contrario se desactiva el boton para dar de baja
        private void frmProveedor_Load(object sender, EventArgs e)
        {
            if (editMode)
            {
                proveedor = new Proveedor(codigoProveedor);
                txtNombreProveedor.Text = proveedor.nombre;
                txtApellidoProveedor.Text = proveedor.apellido;
                txtDireccionProveedor.Text = proveedor.direccion;
                txtTelefonoProveedor.Text = proveedor.telefono;
                this.Text = "Editando Proveedor número " + proveedor.codigoProveedor.ToString();
                btnSaveProveedor.Text = "Guardar Cambios";
            }
            else
            {
                btnDeleteProveedor.Visible = false;
            }
        }

        //Chequea que todos los datos esten ingresados. Si lo estan procede a guardar el proveedor nuevo o a editarlo
        // si se estaba editando
        private void btnSaveProveedor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreProveedor.Text) ||
                string.IsNullOrEmpty(txtApellidoProveedor.Text) ||
                string.IsNullOrEmpty(txtTelefonoProveedor.Text) ||
                string.IsNullOrEmpty(txtDireccionProveedor.Text))
            {
                MessageBox.Show("Debes completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (editMode)
            {
                proveedor.nombre = txtNombreProveedor.Text;
                proveedor.apellido = txtApellidoProveedor.Text;
                proveedor.direccion = txtDireccionProveedor.Text;
                proveedor.telefono = txtTelefonoProveedor.Text;
                proveedor.save();
                form.frmProveedores_Load(null, null);
                this.Close();
            }
            else
            {
                new Proveedor(codigoProveedor, txtNombreProveedor.Text, txtApellidoProveedor.Text, txtDireccionProveedor.Text, txtTelefonoProveedor.Text).save();
                var confirmResult = MessageBox.Show("Se ha guardado con éxito el proveedor! Desea agregar otro?",
                    "Resultado", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    clean();
                }
                else
                {
                    form.frmProveedores_Load(null, null);
                    this.Close();
                }
            }

        }

        //Previa confirmacion del usuario da de baja el proveedor
        private void btnDeleteProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show("Está seguro que desea deshabilitar este proveedor?",
                                         "Dar de baja!",
                                         MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    proveedor.available(false);
                    form.frmProveedores_Load(null, null);
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK);
            }
        }

        //Limpia los campos del formulario
        private void clean()
        {
            codigoProveedor = 0;
            txtNombreProveedor.Text = "";
            txtApellidoProveedor.Text = "";
            txtDireccionProveedor.Text = "";
            txtTelefonoProveedor.Text = "";
        }
    }
}
