using System;
using System.Windows.Forms;
using Ferreteria.Models;
namespace Ferreteria.Forms
{
    public partial class frmPerfil : Form
    {
        int idProfile = 0;
        frmPerfiles form = null;

        //Inicializa el formulario con los datos pasados por parametro
        public frmPerfil(frmPerfiles form, int id)
        {
            this.form = form;
            idProfile = id;
            InitializeComponent();
        }

        //Si se esta editando configura los datos del perfil a editar al cargar la ventana
        private void frmNuevoPerfil_Load(object sender, EventArgs e)
        {
            txtIdProfile.Text = idProfile + "";
            if (idProfile != 0)
                txtNameProfile.Text = new TipoEmpleado(idProfile).nombre;
        }

        //Limpia los distintos campos
        private void clean()
        {
            idProfile = 0;
            txtIdProfile.Text = "0";
            txtNameProfile.Text = "";
        }

        //Primero corrobora si estan completos todos los datos solicitados. Si ese es el caso, procede a guardar un
        // nuevo perfil o a editar uno existente si se esta editando
        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNameProfile.Text))
            {
                MessageBox.Show("Debes completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (new TipoEmpleado(idProfile, txtNameProfile.Text).save())
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

        //Pide confirmacion para dar de baja un perfil. Caso afirmativo, procede a darlo de baja
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
