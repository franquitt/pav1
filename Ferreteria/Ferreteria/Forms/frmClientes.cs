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

        public void frmClientes_Load(object sender, EventArgs e)
        {
            gridClientes.DataSource = Cliente.GetAllClientes();
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            frmCliente f = new frmCliente(0, this, false);
            f.Show();
        }

        private void gridClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Helper.getSelectedId(gridClientes);
            frmCliente f = new frmCliente(id, this, true);
            f.Show();
        }
    }
}
