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
    public partial class frmProvsProds : Form
    {
        public frmProvsProds()
        {
            InitializeComponent();
        }

        public void frmProvsProds_Load(object sender, EventArgs e)
        {
            gridProvProd.DataSource = ProvXProd.GetAllProvProd();
            gridProvProd.Columns[0].Visible = false;
            gridProvProd.Columns[1].Visible = false;
        }

        private void btnAgregarProvProd_Click(object sender, EventArgs e)
        {
            new frmProvProd(0, 0, this, false).Show();
        }

        private void gridProvProd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int codProv = Helper.getSelectedId(gridProvProd);
            int codProd = Helper.getSelectedId(gridProvProd, 1);
            new frmProvProd(codProd, codProv, this, true).Show();
        }
    }
}
