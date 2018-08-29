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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                MessageBox.Show("Se debe ingresar un usuario.");
                return;
            }

            if ((txtPass.Text == ""))
            {
                MessageBox.Show("Se debe ingresar una contraseña.");
                return;
            }

            frmInicio principal = new frmInicio();
            if (principal.validarUsuario(txtUser.Text, txtPass.Text))
            {
                MessageBox.Show("Usted a ingresado al sistema.");
                //this.Close();
            }
            else
            {
                txtUser.Text = "";
                txtPass.Text = "";
                MessageBox.Show("Debe ingresar usuario y/o contraseña válidos");
            }
        }
    }
}
