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
        }

        private void gridClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idProveedor = Helper.getSelectedId(gridProveedores);
            frmProveedor frmProv = new frmProveedor(idProveedor, this, true);
            frmProv.Show();
        }
    }
}
