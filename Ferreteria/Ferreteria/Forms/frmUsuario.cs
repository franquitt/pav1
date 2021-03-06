﻿using System;
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

        public void SetForm(frmEmpleado form)
        {
            this.form = form;
        }

        //Al cargar la ventana, carga el combobox de tipo de usuario con todos los tipos. Si se esta agregando uno
        // nuevo, deshabilita el boton dar de baja, si se esta editando, llena los campos con los datos del usuario
        // a editar
        private void NuevoUsuario_Load(object sender, EventArgs e)
        {
            Helper.llenarCbo(cboTipoUser, TipoEmpleado.GetAllUserTypes(), "nombre", "codigoTipo");
            txtLegajo.ReadOnly = true;

            if (agregando)
            {
                btnDelUser.Visible = false;
            }
            else
            {
                empleado = new Empleado(legajo);
                txtLegajo.Text = empleado.legajo.ToString();
                txtNombre.Text = empleado.nombre;
                txtApellido.Text = empleado.apellido;
                txtFechaNac.Text = empleado.fechaNacimiento.ToString("yyyy-MM-dd");
                txtTelefono.Text = empleado.telefono;
                this.Text += " - Id: " + empleado.legajo.ToString();
                btnAgregarUsuario.Text = "Guardar cambios";
                cboTipoUser.SelectedValue = empleado.tipo.codigoTipo;
            }
            
        }

        //Limpia los campos del formulario
        private void Clean()
        {
            txtLegajo.Text = "";
            txtPass.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtFechaNac.Text = "";
            txtTelefono.Text = "";
        }

        //Primero chequea que todos los campos esten completos. Una vez hecho esto crea un nuevo usuario o guarda
        // los cambios del usuario que se estaba editando
        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtApellido.Text) ||
                string.IsNullOrEmpty(txtNombre.Text) ||
                string.IsNullOrEmpty(txtFechaNac.Text) ||
                string.IsNullOrEmpty(txtTelefono.Text) ||
                (cboTipoUser.SelectedIndex == -1))
            {
                MessageBox.Show("Debes completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime timeNow = DateTime.Now;
            TipoEmpleado tipo = new TipoEmpleado((int)cboTipoUser.SelectedValue);
            DateTime fechaNac = DateTime.Parse(txtFechaNac.Text);
            if (agregando)
            {
                if (string.IsNullOrEmpty(txtPass.Text))
                {
                    MessageBox.Show("Debes completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if ( new Empleado(timeNow, txtTelefono.Text, fechaNac, txtNombre.Text, txtApellido.Text, txtPass.Text, tipo, timeNow, true).save())
                {

                    var confirmResult = MessageBox.Show("Se ha guardado con éxito el usuario! Desea agregar otro?",
                                        "Resultado",
                                        MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                        Clean();
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

                MessageBox.Show("Se han guardado con éxito los cambios!",
                                    "Resultado",
                                    MessageBoxButtons.OK);
                form.Vendedores_Load(null, null);
                this.Close();
            }

        }

        //Previa confirmacion del usuario, procede a dar de baja el usuario elegido
        private void btnDelUser_Click(object sender, EventArgs e)
        {
            if (Helper.loguedUser.legajo == legajo)
            {
                MessageBox.Show("No puedes borrar el usuario con el que estás logueado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
