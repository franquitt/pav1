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
            new frmTipoFactura(this, 0, false).Show();
        }

        private void gridTipoFacturas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Helper.getSelectedId(gridTipoFacturas);
            new frmTipoFactura(this, id, true).Show();
        }
    }
}
