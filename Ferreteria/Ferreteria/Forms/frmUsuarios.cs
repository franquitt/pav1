using System;
using System.Windows.Forms;
using Ferreteria.Models;
namespace Ferreteria
{
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();            
        }

        public void Vendedores_Load(object sender, EventArgs e)
        {
            gridVendedores.DataSource = Empleado.GetAllEmployes();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmNuevoUsuario form = new frmNuevoUsuario(true);
            form.setForm(this);
            form.Show();
        }

        private void gridVendedores_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Helper.getSelectedId(gridVendedores);

            frmNuevoUsuario form = new frmNuevoUsuario(false);
            form.setForm(this);
            form.legajo = id;
            form.Show();
        }
    }
}
