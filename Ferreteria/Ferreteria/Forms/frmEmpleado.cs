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
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();            
        }
        private void lstUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Vendedores_Load(object sender, EventArgs e)
        {
            gridVendedores.DataSource = Empleado.GetAllEmployes();
        }

        private void btnDelUser_Click(object sender, EventArgs e)
        {
            try
            {
                int leg = (int)gridVendedores.SelectedRows[0].Cells[0].Value;
                string nombre = gridVendedores.SelectedRows[0].Cells[1].Value.ToString();
                string apellido = gridVendedores.SelectedRows[0].Cells[2].Value.ToString();
                var confirmResult = MessageBox.Show("Esta seguro que desea dar de baja al usuario " + apellido + " " + nombre + " ?",
                                         "Dar de baja!",
                                         MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    new Empleado(leg).available(false);
                    Vendedores_Load(null, null);
                }
            }catch(Exception){
                MessageBox.Show("Se produjo un error, asegurese de seleccionar toda la fila.", "Error", MessageBoxButtons.OK);
            }            
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            new frmNuevoUsuario().Show();
        }
    }
}
