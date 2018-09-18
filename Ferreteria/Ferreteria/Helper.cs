using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace Ferreteria
{
    class Helper
    {

        //Realiza un hash del texto enviado mediante el algoritmo SHA256
        public static string sha256(string randomString)
        {
            var crypt = new System.Security.Cryptography.SHA256Managed();
            var hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(randomString));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }

        //Valida un usuario contra la DB. En caso de ser correcto el legajo y pass devuelve true
        public static bool validarUsuario(string legajo, string pass)
        {
            pass = Helper.sha256(pass);
            DataTable tabla = BDHelper.ConsultaSQL("SELECT * FROM USUARIO WHERE legajo =  \'"
                            + legajo + "\' AND password = \'"
                            + pass + "\'");


            if (tabla.Rows.Count > 0)
                return true;
            else
                return false;
        }

        //Devuelve el ID de la fila seleccionada en un DataGrid pasado como parametro
        public static int getSelectedId(System.Windows.Forms.DataGridView grid)
        {
            int id = 0;
            try
            {
                id = (int)grid.SelectedRows[0].Cells[0].Value;
            }
            catch
            {
                try
                {
                    id = (int)grid.Rows[(int)grid.SelectedCells[0].RowIndex].Cells[0].Value;
                }
                catch
                {

                }
            }
            return id;
        }
    }
}
