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
    public partial class frmLotes : Form
    {
        public frmLotes()
        {
            InitializeComponent();
        }

        //Carga los lotes existentes en la grilla
        public void frmLotes_Load(object sender, EventArgs e)
        {
            gridLotes.DataSource = Lote.getAllLotes();
        }

        //Abre el formulario para agregar un nuevo lote
        private void btnAgregarLote_Click(object sender, EventArgs e)
        {
            new frmLote(0, false, this).Show();
        }

        //Abre el formulario para editar el lote seleccionado
        private void gridLotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Helper.getSelectedId(gridLotes);
            new frmLote(id, true, this).Show();
        }
    }
}
