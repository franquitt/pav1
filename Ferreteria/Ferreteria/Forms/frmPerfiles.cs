using System;
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

        //carga en una grilla todos los perfiles existentes
        public void frmPerfiles_Load(object sender, EventArgs e)
        {
            gridProfiles.DataSource = TipoEmpleado.GetAllUserTypes();
        }

        //abre el formulario para agregar un nuevo perfil
        private void btnAddProfile_Click(object sender, EventArgs e)
        {
            new frmPerfil(this, 0).Show();
        }

        //abre el formulario para editar un nuevo perfil pasando el id del perfil a editar como parametro
        private void gridProfiles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Helper.getSelectedId(gridProfiles);
            new frmPerfil(this, id).Show();
        }
    }
}
