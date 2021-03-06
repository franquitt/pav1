﻿using System;
using System.Windows.Forms;
using Ferreteria.Models;

namespace Ferreteria.Forms
{
    public partial class frmClasificacion : Form
    {
        int id = 0;
        frmClasificaciones form = null;
        bool editMode = true;
        Clasificacion clasificacion = null;

        //Iniciliza el formulario
        public frmClasificacion(int id, frmClasificaciones form, bool editMode)
        {
            InitializeComponent();
            this.id = id;
            this.form = form;
            this.editMode = editMode;
        }

        //Cuando carga el formulario rellena los campos con los datos de la clasificacion a editar si se esta editando
        //Caso contrario se desactiva el boton para dar de baja
        private void frmClasificacion_Load(object sender, EventArgs e)
        {
            if (editMode)
            {
                clasificacion = new Clasificacion(id);
                txtNombreClasificacion.Text = clasificacion.nombre;
                txtDescripcionClasificacion.Text = clasificacion.descripcion;
                this.Text += " - Id: " + clasificacion.codigoClasificacion.ToString();
                btnSaveClasificacion.Text = "Guardar cambios";
            } else
            {
                btnDeleteClasificacion.Visible = false;
            }
        }

        //Permite dar de baja la clasificacion que se está modificando
        private void btnDeleteClasificacion_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show("Esta seguro que desea deshabilitar esta clasificacion?",
                                         "Dar de baja!",
                                         MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    clasificacion.available(false);
                    form.frmClasificaciones_Load(null, null);
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK);
            }
        }

        //Si se esta creando una nueva, la crea y permite seguir agregando. Si se esta editando guarda los cambios y
        //vuelve a la lista
        //Al principio chequea que se haya ingresado todo lo necesario y no permite el guardado si no es asi
        private void btnSaveClasificacion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreClasificacion.Text) || string.IsNullOrEmpty(txtDescripcionClasificacion.Text))
            {
                MessageBox.Show("Debes completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!editMode) {
                new Clasificacion(id, txtNombreClasificacion.Text, txtDescripcionClasificacion.Text).save();
                var confirmResult = MessageBox.Show("Se ha guardado con éxito la clasificacion! Desea agregar otra?",
                    "Resultado", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes) {
                    clean();
                } else {
                    form.frmClasificaciones_Load(null, null);
                    this.Close();
                }
            } else
            {
                clasificacion.nombre = txtNombreClasificacion.Text;
                clasificacion.descripcion = txtDescripcionClasificacion.Text;
                clasificacion.save();
                form.frmClasificaciones_Load(null, null);
                this.Close();
            }
        }

        //Limpia los campos
        private void clean()
        {
            id = 0;
            txtNombreClasificacion.Text = "";
            txtDescripcionClasificacion.Text = "";
        }
    }
}
