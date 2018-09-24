﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ferreteria.Models;

namespace Ferreteria.Forms
{
    public partial class frmProducto : Form
    {
        int id = 0;
        frmProductos formProductos = null;
        bool editMode = false;
        Producto producto = null;

        public frmProducto(int id, frmProductos productos, bool editMode)
        {
            this.id = id;
            this.formProductos = productos;
            this. editMode = editMode;
            InitializeComponent();
        }

        //Cuando carga el formulario rellena los campos con los datos del producto a editar si se esta editando
        //Caso contrario se desactiva el boton para dar de baja
        private void frmProducto_Load(object sender, EventArgs e)
        {
            cmbClasificacion.DataSource = Clasificacion.GetAllClasificaciones();
            cmbClasificacion.DisplayMember = "nombre";
            cmbClasificacion.ValueMember = "codigoClasificacion";

            if (editMode)
            {
                producto = new Producto(id);
                txtNombreProducto.Text = producto.nombre;
                txtPrecioProducto.Text = producto.precio.ToString();
                txtDescripcionProducto.Text = producto.descripcion;
                this.Text += " - Id: " + producto.codigoProducto.ToString();
                btnSaveProducto.Text = "Guardar cambios";
            }
            else
            {
                btnDeleteProducto.Visible = false;
            }
        }

        //Limpia los campos
        private void clean()
        {
            id = 0;
            txtNombreProducto.Text = "";
            txtPrecioProducto.Text = "";
            txtDescripcionProducto.Text = "";
        }

        private void btnSaveProducto_Click(object sender, EventArgs e)
        {
            if (!editMode)
            {
                new Producto(id, txtNombreProducto.Text, decimal.Parse(txtPrecioProducto.Text.Replace(".", ",")), txtDescripcionProducto.Text, (int)cmbClasificacion.SelectedValue).save();
                var confirmResult = MessageBox.Show("Se ha guardado con éxito el tipo de factura! Desea agregar otro?",
                    "Resultado", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    clean();
                }
                else
                {
                    formProductos.frmProductos_Load(null, null);
                    this.Close();
                }
            }
            else
            {
                producto.nombre = txtNombreProducto.Text;
                producto.descripcion = txtDescripcionProducto.Text;
                producto.precio = decimal.Parse(txtPrecioProducto.Text.Replace(".",","));
                producto.codigoClasificacion = (int)cmbClasificacion.SelectedValue;
                producto.save();
                formProductos.frmProductos_Load(null, null);
                this.Close();
            }
        }
    }
}
