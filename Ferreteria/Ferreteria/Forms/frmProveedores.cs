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

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            frmProveedor frmProv = new frmProveedor(0,this,false);
            frmProv.Show();
        }

        public void frmProveedores_Load(object sender, EventArgs e)
        {
            gridProveedores.DataSource = Proveedor.GetAllProveedores();
            gridProveedores.Columns[0].Width = 25;
        }

        private void gridClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idProveedor = Helper.getSelectedId(gridProveedores);
            frmProveedor frmProv = new frmProveedor(idProveedor, this, true);
            frmProv.Show();
        }
    }
}
