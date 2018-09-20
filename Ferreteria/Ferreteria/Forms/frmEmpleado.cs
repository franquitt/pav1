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

        public void Vendedores_Load(object sender, EventArgs e)
        {
            gridVendedores.DataSource = Empleado.GetAllEmployes();
        }

        private void btnDelUser_Click(object sender, EventArgs e)
        {
            int id = Helper.getSelectedId(gridVendedores);
            try
            {
                Empleado empleado = new Empleado(id);
                var confirmResult = MessageBox.Show("Esta seguro que desea dar de baja al usuario " + empleado.apellido + " " + empleado.nombre + " ?",
                                         "Dar de baja!",
                                         MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    empleado.available(false);
                    Vendedores_Load(null, null);
                }
            }catch(Exception){
                MessageBox.Show("Se produjo un error, asegurese de seleccionar toda la fila.", "Error", MessageBoxButtons.OK);
            }            
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmNuevoUsuario form = new frmNuevoUsuario(true);
            form.setForm(this);
            form.Show();
        }

        private void gridVendedores_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Helper.getSelectedId(gridVendedores);

            frmNuevoUsuario form = new frmNuevoUsuario(false);
            form.setForm(this);
            form.legajo = id;
            form.Show();
        }
    }
}
