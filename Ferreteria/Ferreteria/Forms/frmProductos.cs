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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        //Carga los formProductos existentes en la grilla
        public void frmProductos_Load(object sender, EventArgs e)
        {
            gridProductos.DataSource = Producto.GetAllProductos();
            gridProductos.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        //Abre el formulario para agregar un nuevo producto
        private void btnAddProducto_Click(object sender, EventArgs e)
        {
            new frmProducto(0, this, false).Show();
        }

        //Abre el formulario para editar el producto seleccionado
        private void gridProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Helper.getSelectedId(gridProductos);
            new frmProducto(id, this, true).Show();
        }
    }
}