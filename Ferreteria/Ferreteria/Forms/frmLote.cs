using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ferreteria.Models;

namespace Ferreteria.Forms
{
    public partial class frmLote : Form
    {
        bool editMode = false;
        frmLotes formLotes = null;
        int idLote = 0;
        Lote lote = null;

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
                lote = new Lote(idLote);
                txtCantidad.Text = lote.stockInicial.ToString();
                txtFecha.Text = lote.fechaIngreso.ToString("dd-MM-yyyy");
                this.Text += " - Id: " + lote.nroLote.ToString();
                btnSaveLote.Text = "Guardar cambios";
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
                    formLotes.frmLotes_Load(null, null);
                    this.Close();
                }
            }
            else
            {
                lote.stockInicial = int.Parse(txtCantidad.Text);
                lote.stockActual = int.Parse(txtCantidad.Text);
                lote.fechaIngreso = DateTime.Parse(txtFecha.Text);
                lote.codigoProducto = int.Parse(cboProducto.SelectedValue.ToString());
                lote.codigoProveedor = int.Parse(cboProveedor.SelectedValue.ToString());
                lote.save();
                formLotes.frmLotes_Load(null, null);
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

        private void txtBusquedaProducto_TextChanged(object sender, EventArgs e)
        {
            string aBuscar = txtBusquedaProducto.Text;
            cboProducto.DroppedDown = false;
            Helper.llenarCbo(cboProducto, Producto.GetAllProductosByName(aBuscar), "nombre", "codigoProducto");
            cboProducto.DroppedDown = true;
        }

        private void txtBusquedaProveedor_TextChanged(object sender, EventArgs e)
        {
            string aBuscar = txtBusquedaProveedor.Text;
            cboProveedor.DroppedDown = false;
            Helper.llenarCbo(cboProveedor, Proveedor.GetAllProveedoresByName(aBuscar), "nombre", "codigoProveedor");
            cboProveedor.DroppedDown = true;
        }
    }
}
