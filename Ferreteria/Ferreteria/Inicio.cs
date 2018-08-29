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

        public bool validar(string user, string pass)
        {
            BDHelper helper = new BDHelper();
            DataTable tabla = helper.ConsultaSQL("SELECT * FROM USERS WHERE usuario =  \'"
                            + user + "\' AND password = \'"
                            + pass + "\'");


            if (tabla.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
