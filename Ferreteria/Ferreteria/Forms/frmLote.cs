using System;
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
            Helper.llenarCbo(cboProducto, Producto.GetNames(), "nombre", "codigoProducto");
            if (editMode)
            {
                lote = new Lote(idLote);
                cboProducto.SelectedValue = lote.codigoProducto;
                Helper.llenarCbo(cboProveedor, Proveedor.GetAllProveedoresByProducto(lote.codigoProducto), "fullname", "codigoProveedor");
                cboProveedor.SelectedValue = lote.codigoProveedor;
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
                new Lote(int.Parse(cboProveedor.SelectedValue.ToString()), int.Parse(cboProducto.SelectedValue.ToString()), int.Parse(txtCantidad.Text), int.Parse(txtCantidad.Text), DateTime.Parse(txtFecha.Text)).save();
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
        }

        private void txtBusquedaProducto_TextChanged(object sender, EventArgs e)
        {
            string aBuscar = txtBusquedaProducto.Text;
            cboProducto.DroppedDown = false;
            Helper.llenarCbo(cboProducto, Producto.GetAllProductosByName(aBuscar), "nombre", "codigoProducto");
            cboProducto.DroppedDown = true;
        }

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Helper.llenarCbo(cboProveedor, Proveedor.GetAllProveedoresByProducto(int.Parse(cboProducto.SelectedValue.ToString())), "fullname", "codigoProveedor");
            }
            catch { }
        }
    }
}
