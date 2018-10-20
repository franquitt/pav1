using System;
using System.Windows.Forms;
using Ferreteria.Models;

namespace Ferreteria.Forms
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        //Carga los formProductos existentes en la grilla
        public void frmProductos_Load(object sender, EventArgs e)
        {
            gridProductos.DataSource = Producto.GetAllProductos();
            gridProductos.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            gridProductos.Columns[0].Width = 25;
        }

        //Abre el formulario para agregar un nuevo producto
        private void btnAddProducto_Click(object sender, EventArgs e)
        {
            new frmProducto(0, this, false).Show();
        }

        //Abre el formulario para editar el producto seleccionado
        private void gridProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Helper.getSelectedId(gridProductos);
            Console.WriteLine(id);
            new frmProducto(id, this, true).Show();
        }

        private void btnAsociarConProveedor_Click(object sender, EventArgs e)
        {
            new frmProvsProds().Show();
        }
    }
}
