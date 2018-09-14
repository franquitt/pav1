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

namespace Ferreteria.Forms
{
    public partial class frmTipoFacturas : Form
    {
        public frmTipoFacturas()
        {
            InitializeComponent();
        }

        //Carga los tipos de factura existentes en la grilla
        public void frmTipoFacturas_Load(object sender, EventArgs e)
        {
            gridTipoFacturas.DataSource = TipoFactura.GetAllTipoFacturas();
        }

        //Abre el formulario para agregar un nuevo tipo de factura
        private void btnAddTipoFactura_Click(object sender, EventArgs e)
        {

        }

        //Abre el formulario para editar el tipo de factura seleccionado
        private void btnEditTipoFactura_Click(object sender, EventArgs e)
        {

        }

        //Permite dar de baja el tipo de factura elegido
        private void btnRemoveTipoFactura_Click(object sender, EventArgs e)
        {
            int id = Helper.getSelectedId(gridTipoFacturas);
            try
            {
                TipoFactura tipoFactura = new TipoFactura(id);
                var confirmResult = MessageBox.Show("Esta seguro que desea deshabilitar el tipo de factura " + tipoFactura.nombre + " ?",
                                         "Dar de baja!",
                                         MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    tipoFactura.available(false);
                    frmTipoFacturas_Load(null, null);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Se produjo un error, asegurese de seleccionar toda la fila.", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
