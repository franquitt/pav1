using System;
using System.Windows.Forms;
using Ferreteria.Forms;
namespace Ferreteria
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
            Helper.checkDateFormat();
            Helper.convertDate(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }
        private void frmInicio_Load(object sender, EventArgs e)
        {
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tipoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmPerfiles().Show();
        }

        private void vendedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmEmpleado().Show();
        }

        private void tipoDeFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmTipoFacturas().Show();
        }

        private void clasificacionDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmClasificaciones().Show();
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmProductos().Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmClientes().Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmProveedores().Show();
        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmVenta().Show();
        }

        private void lotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmLotes().Show();
        }

        private void asociacionesProveedoresProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmProvsProds().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmInformeTop10().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmInformeWorst10().Show();
        }

        private void frmInicio_Load_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new frmInformeTopSellers().Show();
        }
    }
}
