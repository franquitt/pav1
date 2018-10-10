using System;
using System.Windows.Forms;
using Ferreteria.Models;
namespace Ferreteria.Forms
{
    public partial class frmNuevoPerfil : Form
    {
        int idProfile = 0;
        frmPerfiles form = null;

        public frmNuevoPerfil(frmPerfiles form, int id)
        {
            this.form = form;
            idProfile = id;
            InitializeComponent();
        }

        private void frmNuevoPerfil_Load(object sender, EventArgs e)
        {
            txtIdProfile.Text = idProfile + "";
            if (idProfile != 0)
                txtNameProfile.Text = new TipoEmpleado(idProfile).nombre;
        }

        private void clean()
        {
            idProfile = 0;
            txtIdProfile.Text = "0";
            txtNameProfile.Text = "";
        }

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            if(new TipoEmpleado(idProfile, txtNameProfile.Text).save())
            {
                var confirmResult = MessageBox.Show("Se ha guardado con éxito el perfil! Desea agregar otro?",
                                       "Resultado",
                                       MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                    clean();
                else
                {
                    form.frmPerfiles_Load(null, null);
                    this.Close();
                }
            }
            else
            {

            }
        }

        private void btnDelProfile_Click(object sender, EventArgs e)
        {
            TipoEmpleado tipo = new TipoEmpleado(idProfile);
            var confirmResult = MessageBox.Show("Esta seguro que desea deshabilitar el perfil " + tipo.nombre + " ?",
                                     "Dar de baja!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                tipo.available(false);
                this.Hide();
                form.frmPerfiles_Load(null, null);
            }
        }
    }
}
