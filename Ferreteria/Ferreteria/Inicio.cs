using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        public bool validarUsuario(string legajo, string pass)
        {
            pass = Helper.sha256(pass);
            BDHelper helper = new BDHelper();
            DataTable tabla = helper.ConsultaSQL("SELECT * FROM USUARIOS WHERE legajo =  \'"
                            + legajo + "\' AND password = \'"
                            + pass + "\'");


            if (tabla.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
