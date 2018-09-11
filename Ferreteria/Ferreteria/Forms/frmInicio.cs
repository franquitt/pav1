using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }
        private void frmInicio_Load(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tipoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vendedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmEmpleado().Show();
        }
    }
}
