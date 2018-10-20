using System;
using System.Windows.Forms;
using Ferreteria.Models;

namespace Ferreteria.Forms
{
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        //Abre el formulario para agregar un nuevo cliente
        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            new frmProveedor(0,this,false).Show();
        }

        //Al cargar la ventana, carga los datos de todos los proveedores y modifica el tamaño de las columnas
        public void frmProveedores_Load(object sender, EventArgs e)
        {
            gridProveedores.DataSource = Proveedor.GetAllProveedores();
            gridProveedores.Columns[0].Width = 25;
        }

        //abre la ventana para editar un proveedor pasando como parametro el id del proveedor elegido
        private void gridClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idProveedor = Helper.getSelectedId(gridProveedores);
            new frmProveedor(idProveedor, this, true).Show();
        }
    }
}
