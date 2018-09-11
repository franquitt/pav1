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
    public partial class Empleado : Form
    {
        public Empleado()
        {
            InitializeComponent();            
        }
        private void lstUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Vendedores_Load(object sender, EventArgs e)
        {
            DataTable usuarios = BDHelper.ConsultaSQL("SELECT legajo AS 'Legajo', USUARIOS.nombre, apellido, TIPO_USUARIO.nombre AS 'Tipo de Usuario' FROM USUARIOS JOIN TIPO_USUARIO ON(USUARIOS.tipo=TIPO_USUARIO.codigoTipo) WHERE activo = 1 ORDER BY apellido, nombre");
            gridVendedores.DataSource = usuarios;
        }

        private void btnDelUser_Click(object sender, EventArgs e)
        {
            try
            {
                string leg = gridVendedores.SelectedRows[0].Cells[0].Value.ToString();
                string nombre = gridVendedores.SelectedRows[0].Cells[1].Value.ToString();
                string apellido = gridVendedores.SelectedRows[0].Cells[2].Value.ToString();
                var confirmResult = MessageBox.Show("Esta seguro que desea dar de baja al usuario " + apellido + " " + nombre + " ?",
                                         "Dar de baja!",
                                         MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    BDHelper.ExcecuteSQL("UPDATE USUARIOS SET activo = 0 WHERE legajo = "+leg);
                    Vendedores_Load(null, null);
                }
            }catch(Exception){
                MessageBox.Show("Se produjo un error, asegurese de seleccionar toda la fila.", "Error", MessageBoxButtons.OK);
            }            
        }
    }
}
