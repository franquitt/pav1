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
        public int legajo = 0;
        frmEmpleado form;
        Empleado empleado;
        public frmNuevoUsuario(bool agregando)
        {
            this.agregando = agregando;
            InitializeComponent();
        }
        public void setForm(frmEmpleado form)
        {
            this.form = form;
        }
        private void NuevoUsuario_Load(object sender, EventArgs e)
        {
            cmbTipoUser.DataSource = TipoEmpleado.GetAllUserTypes();
            cmbTipoUser.DisplayMember = "nombre";
            cmbTipoUser.ValueMember = "codigoTipo";
            txtLegajo.ReadOnly = true;
            if (legajo != 0)
            {
                empleado = new Empleado(legajo);
                txtLegajo.Text = empleado.legajo.ToString();
                txtNombre.Text = empleado.nombre;
                txtApellido.Text = empleado.apellido;
                txtFechaNac.Text = empleado.fechaNacimiento.ToString("yyyy-MM-dd");
                txtTelefono.Text = empleado.telefono;
            }
            
        }
        private void clean()
        {
            txtLegajo.Text = "";
            txtPass.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtFechaNac.Text = "";
            txtTelefono.Text = "";
        }
        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            DateTime timeNow = DateTime.Now;
            TipoEmpleado tipo = new TipoEmpleado((int)cmbTipoUser.SelectedValue);
            DateTime fechaNac = DateTime.Parse(txtFechaNac.Text);
            if (agregando)
            {
                if ( new Empleado(timeNow, txtTelefono.Text, fechaNac, txtNombre.Text, txtApellido.Text, txtPass.Text, tipo, timeNow, true).save())
                {

                    var confirmResult = MessageBox.Show("Se ha guardado con éxito el usuario! Desea agregar otro?",
                                        "Resultado",
                                        MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                        clean();
                    else
                    {
                        form.Vendedores_Load(null, null);
                        this.Close();
                    }
                        
                }
                return;
            }
            if (new Empleado(legajo, timeNow, txtTelefono.Text, fechaNac, txtNombre.Text, txtApellido.Text, txtPass.Text, tipo, timeNow, true).save())
            {

                var confirmResult = MessageBox.Show("Se ha guardado con éxito el usuario! Desea agregar otro?",
                                    "Resultado",
                                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    agregando = true;
                    legajo = 0;
                    clean();
                }
                else
                {
                    form.Vendedores_Load(null, null);
                    this.Close();
                }

            }

        }

        private void btnDelUser_Click(object sender, EventArgs e)
        {

            Empleado empleado = new Empleado(legajo);
            var confirmResult = MessageBox.Show("Esta seguro que desea dar de baja al usuario " + empleado.apellido + " " + empleado.nombre + " ?",
                                        "Dar de baja!",
                                        MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                empleado.available(false);
                form.Vendedores_Load(null, null);
                this.Close();
            }
        }
    }
}
