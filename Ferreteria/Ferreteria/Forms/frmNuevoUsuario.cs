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
namespace Ferreteria
{
    public partial class frmNuevoUsuario : Form
    {
        bool agregando = true;
        public frmNuevoUsuario()
        {
            InitializeComponent();
        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {
            cmbTipoUser.DataSource = TipoEmpleado.GetAllUsersTypes();
            cmbTipoUser.DisplayMember = "nombre";
            cmbTipoUser.ValueMember = "codigoTipo";
        }
    }
}
