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
    public partial class frmPerfiles : Form
    {
        public frmPerfiles()
        {
            InitializeComponent();
        }

        public void frmPerfiles_Load(object sender, EventArgs e)
        {
            gridProfiles.DataSource = TipoEmpleado.GetAllUserTypes();
        }

        private void btnAddProfile_Click(object sender, EventArgs e)
        {
            new frmNuevoPerfil(this, 0).Show();
        }

        private void gridProfiles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Helper.getSelectedId(gridProfiles);
            new frmNuevoPerfil(this, id).Show();
        }
    }
}
