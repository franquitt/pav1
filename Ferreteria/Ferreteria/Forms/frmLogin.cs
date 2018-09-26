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
            double Num;
            if (!double.TryParse(txtUser.Text, out Num))
            {
                MessageBox.Show("Se debe ingresar un usuario valido.");
                return;
            }
            
            if (Helper.validarUsuario(txtUser.Text, txtPass.Text))
            {
                this.Hide();                
            }
            else
            {
                txtUser.Text = "";
                txtPass.Text = "";
                MessageBox.Show("Debe ingresar usuario y/o contraseña válidos");
                txtUser.Focus();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
