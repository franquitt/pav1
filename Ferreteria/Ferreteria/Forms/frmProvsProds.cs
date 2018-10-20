using System;
using System.Windows.Forms;
using Ferreteria.Models;

namespace Ferreteria.Forms
{
    public partial class frmProvsProds : Form
    {
        public frmProvsProds()
        {
            InitializeComponent();
        }

        //Carga las columnas de la gridView, escondiendo en el proceso las que contienen los id
        public void frmProvsProds_Load(object sender, EventArgs e)
        {
            gridProvProd.DataSource = ProvXProd.GetAllProvProd();
            gridProvProd.Columns[0].Visible = false;
            gridProvProd.Columns[1].Visible = false;
        }

        //Abre el formulario para crear una asociacion nueva
        private void btnAgregarProvProd_Click(object sender, EventArgs e)
        {
            new frmProvProd(0, 0, this, false).Show();
        }

        //Abre el formulario para crear una asociacion existente, pasando los id necesarios
        private void gridProvProd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int codProv = Helper.getSelectedId(gridProvProd);
            int codProd = Helper.getSelectedId(gridProvProd, 1);
            new frmProvProd(codProd, codProv, this, true).Show();
        }
    }
}
