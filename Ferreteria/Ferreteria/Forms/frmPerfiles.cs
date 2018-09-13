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

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            int id = Helper.getSelectedId(gridProfiles);
            try
            {
                new frmNuevoPerfil(this, id).Show();
            }
            catch
            {
                MessageBox.Show("Por favor intente seleccionando nuevamente el perfil a modificar", "Error", MessageBoxButtons.OK);
            }
                

        }

        private void btnRemoveProfile_Click(object sender, EventArgs e)
        {
            int id = Helper.getSelectedId(gridProfiles);
            try
            {
                TipoEmpleado tipo = new TipoEmpleado(id);
                var confirmResult = MessageBox.Show("Esta seguro que desea deshabilitar el perfil " + tipo.nombre + " ?",
                                         "Dar de baja!",
                                         MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    tipo.available(false);
                    frmPerfiles_Load(null, null);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Se produjo un error, asegurese de seleccionar toda la fila.", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
