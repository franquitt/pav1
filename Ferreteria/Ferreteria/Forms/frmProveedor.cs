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

        public frmProveedor(int id, frmProveedores form, bool editMode)
        {
            InitializeComponent();
            this.form = form;
            this.editMode = editMode;
            this.codigoProveedor = id;
        }

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
