﻿using System;
using System.Windows.Forms;
using Ferreteria.Models;

namespace Ferreteria.Forms
{
    public partial class frmCliente : Form
    {
        public bool editMode = false;
        int codigoCliente = 0;
        frmClientes frmClientes = null;
        Cliente cliente = null;

        public frmCliente(int codigoCliente, frmClientes frmClientes, bool editMode)
        {
            InitializeComponent();
            this.codigoCliente = codigoCliente;
            this.frmClientes = frmClientes;
            this.editMode = editMode;
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            if (editMode)
            {
                btnAgregarCliente.Text = "Guardar Cambios";
                this.Text = "Editando cliente " + codigoCliente;
                cliente = new Cliente(codigoCliente);
                txtNombreCliente.Text = cliente.nombre;
                txtApellidoCliente.Text = cliente.apellido;
                txtTelefonoCliente.Text = cliente.telefono;
                txtCuitCliente.Text = cliente.cuit.ToString();
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtApellidoCliente.Text) || 
                string.IsNullOrEmpty(txtCuitCliente.Text) ||
                string.IsNullOrEmpty(txtNombreCliente.Text) ||
                string.IsNullOrEmpty(txtTelefonoCliente.Text))
            {
                MessageBox.Show("Debes completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!editMode)
            {
                new Cliente(codigoCliente, txtNombreCliente.Text, txtApellidoCliente.Text, txtTelefonoCliente.Text, txtCuitCliente.Text).save();
                var confirmResult = MessageBox.Show("Se ha guardado con éxito el cliente! Desea agregar otro?",
                    "Resultado", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    clean();
                }
                else
                {
                    if (frmClientes != null)
                    {
                        frmClientes.frmClientes_Load(null, null);
                    }
                    this.Close();
                }
            }
            else
            {
                cliente.nombre = txtNombreCliente.Text;
                cliente.apellido = txtApellidoCliente.Text;
                cliente.telefono = txtTelefonoCliente.Text;
                cliente.cuit = txtCuitCliente.Text;
                cliente.save();
                frmClientes.frmClientes_Load(null, null);
                this.Close();
            }
        }

        private void clean()
        {
            codigoCliente = 0;
            txtNombreCliente.Text = "";
            txtApellidoCliente.Text = "";
            txtTelefonoCliente.Text = "";
            txtCuitCliente.Text = "";
        }

    }

}
