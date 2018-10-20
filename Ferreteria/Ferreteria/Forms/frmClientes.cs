using System;
using System.Windows.Forms;
using Ferreteria.Models;

namespace Ferreteria.Forms
{
    public partial class frmClientes : Form
    {
       
        public frmClientes()
        {
            InitializeComponent();
        }

        //carga en la grilla los datos de todos los clientes y configura el tamaño de las columnas
        public void frmClientes_Load(object sender, EventArgs e)
        {
            gridClientes.DataSource = Cliente.GetAllClientes();
            gridClientes.Columns[0].Width = 25;
        }

        //abre el formulario para agregar nuevo cliente
        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            new frmCliente(0, this, false).Show();
        }

        //abre el formulario para editar un cliente pasando como parametro el id del cliente a editar
        private void gridClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Helper.getSelectedId(gridClientes);
            new frmCliente(id, this, true).Show();
        }
    }
}
