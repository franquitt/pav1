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

        private void frmPerfiles_Load(object sender, EventArgs e)
        {
            gridProfiles.DataSource = TipoEmpleado.GetAllUsersTypes();
        }

        private void btnAddProfile_Click(object sender, EventArgs e)
        {
            new frmNuevoPerfil(false).Show();
        }
    }
}
