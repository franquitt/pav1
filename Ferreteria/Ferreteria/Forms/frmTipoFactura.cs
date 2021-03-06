﻿using System;
using System.Windows.Forms;
using Ferreteria.Models;

namespace Ferreteria.Forms
{
    public partial class frmTipoFactura : Form
    {
        int id = 0;
        frmTipoFacturas form = null;
        bool editMode = true;
        TipoFactura tipoFactura = null;

        //Inicializa el formulario con los datos pasados como parametro
        public frmTipoFactura(frmTipoFacturas form, int id, bool editMode)
        {
            InitializeComponent();
            this.id = id;
            this.form = form;
            this.editMode = editMode;
        }

        //Cuando carga el formulario rellena los campos con los datos de la clasificacion a editar si se esta editando
        //Caso contrario se desactiva el boton para dar de baja
        private void frmNuevoTipoFactura_Load(object sender, EventArgs e)
        {
            if (editMode)
            {
                tipoFactura = new TipoFactura(id);
                txtNameTipoFactura.Text = tipoFactura.nombre;
                this.Text += " - Id: " + tipoFactura.codigoTipo.ToString();
                btnSaveTipoFactura.Text = "Guardar cambios";
            }
            else
            {
                btnDeleteTipoFactura.Visible = false;
            }
        }

        //Limpia los campos
        private void clean()
        {
            id = 0;
            txtNameTipoFactura.Text = "";
        }

        //Si se esta creando una nueva, la crea y permite seguir agregando. Si se esta editando guarda los cambios y
        //vuelve a la lista
        private void btnSaveTipoFactura_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNameTipoFactura.Text))
            {
                MessageBox.Show("Debes completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!editMode)
            {
                new TipoFactura(id, txtNameTipoFactura.Text).save();
                var confirmResult = MessageBox.Show("Se ha guardado con éxito el tipo de factura! Desea agregar otro?",
                    "Resultado", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    clean();
                }
                else
                {
                    form.frmTipoFacturas_Load(null, null);
                    this.Close();
                }
            }
            else
            {
                tipoFactura.nombre = txtNameTipoFactura.Text;
                tipoFactura.save();
                form.frmTipoFacturas_Load(null, null);
                this.Close();
            }
        }

        //Previa confirmacion del usuario, da de baja el tipo de factura
        private void btnDeleteTipoFactura_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show("Esta seguro que desea deshabilitar este tipo de factura?",
                                         "Dar de baja!",
                                         MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    tipoFactura.available(false);
                    form.frmTipoFacturas_Load(null, null);
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
