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
    public partial class frmClasificaciones : Form
    {
        public frmClasificaciones()
        {
            InitializeComponent();
        }

        //Carga las clasificaciones existentes en la grilla
        public void frmClasificaciones_Load(object sender, EventArgs e)
        {
            gridClasificaciones.DataSource = Clasificacion.GetAllClasificaciones();
        }

        //Abre el formulario para agregar una nueva clasificacion
        private void btnAddClasificaciones_Click(object sender, EventArgs e)
        {
            new frmClasificacion(0, this, false).Show();
        }

        //Abre el formulario para editar la clasificacion seleccionada
        private void gridClasificaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Helper.getSelectedId(gridClasificaciones);
            new frmClasificacion(id, this, true).Show();
        }
    }
}
