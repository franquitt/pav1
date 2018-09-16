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
    public partial class frmNuevoTipoFactura : Form
    {
        int idTipoFactura = 0;
        frmTipoFacturas form = null;

        //Al crear el formulario lo crea con el id de la factura seleccionada (si se edita) y con id 0 si es nuevo
        public frmNuevoTipoFactura(frmTipoFacturas form, int id)
        {
            this.form = form;
            idTipoFactura = id;
            InitializeComponent();
        }
        
        //Al cargar la ventana carga el id de la factura y el nombre
        private void frmNuevoTipoFactura_Load(object sender, EventArgs e)
        {
            txtIdTipoFactura.Text = idTipoFactura + "";
            if (idTipoFactura != 0)
                txtNameTipoFactura.Text = new TipoFactura(idTipoFactura).nombre;
        }

        //Limpia los campos
        private void clean()
        {
            idTipoFactura = 0;
            txtIdTipoFactura.Text = "0";
            txtNameTipoFactura.Text = "";
        }

        //Guarda el nuevo tipo de factura o los cambios hechos si se estaba editando una existente
        private void btnSaveTipoFactura_Click(object sender, EventArgs e)
        {
            if (new TipoFactura(idTipoFactura, txtNameTipoFactura.Text).save())
            {
                var confirmResult = MessageBox.Show("Se ha guardado con éxito el tipo de factura! Desea agregar otro?",
                                       "Resultado",
                                       MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                    clean();
                else
                {
                    form.frmTipoFacturas_Load(null, null);
                    this.Close();
                }
            }
            else
            {

            }
        }
    }
}
