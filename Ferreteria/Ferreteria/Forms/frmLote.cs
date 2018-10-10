using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria.Forms
{
    public partial class frmLote : Form
    {
        bool editMode = false;
        frmLotes formLotes = null;
        int idLote = 0;
        //Lote lote = null;

        //Iniciliza el formulario
        public frmLote(int id, bool editMode, frmLotes frm)
        {
            this.idLote = id;
            this.editMode = editMode;
            this.formLotes = frm;
            InitializeComponent();
        }

        private void frmLote_Load(object sender, EventArgs e)
        {
            if (editMode)
            {
                //lote = new Lote(id);
                //txtCantidad.Text = lote.stockInicial;
                //txtFecha.Text = lote.fechaIngreso.ToString("dd-MM-yyyy");
                //this.Text += " - Id: " + lote.nroLote.ToString();
                btnSaveLote.Text = "Guardar cambios";
            }
            else
            {
                btnDeleteLote.Visible = false;
            }
        }

        //Permite dar de baja la clasificacion que se está modificando
        private void btnDeleteLote_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show("Esta seguro que desea deshabilitar este lote?",
                                         "Dar de baja!",
                                         MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    //lote.available(false);
                    formLotes.frmLotes_Load(null, null);
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK);
            }
        }

        //Si se esta creando uno nuevo, lo crea y permite seguir agregando. Si se esta editando 
        //guarda los cambios y vuelve a la lista
        private void btnSaveLote_Click(object sender, EventArgs e)
        {
            if (!editMode)
            {
                //new Lote(id, txtNombreClasificacion.Text, txtDescripcionClasificacion.Text).save();
                var confirmResult = MessageBox.Show("Se ha guardado con éxito el lote! Desea agregar otra?",
                    "Resultado", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    clean();
                }
                else
                {
                    form.frmClasificaciones_Load(null, null);
                    this.Close();
                }
            }
            else
            {
                clasificacion.nombre = txtNombreClasificacion.Text;
                clasificacion.descripcion = txtDescripcionClasificacion.Text;
                clasificacion.save();
                form.frmClasificaciones_Load(null, null);
                this.Close();
            }
        }

        //Limpia los campos
        private void clean()
        {
            idLote = 0;
            txtCantidad.Text = "0";
            DateTime now = DateTime.Today;
            txtFecha.Text = now.ToString("dd/MM/yyyy");
            cboProducto.SelectedIndex = -1;
            cboProveedor.SelectedIndex = -1;
            txtBusquedaProducto.Text = "";
            txtBusquedaProveedor.Text = "";
        }
    }
}
