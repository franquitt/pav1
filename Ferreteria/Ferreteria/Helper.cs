using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using Ferreteria.Models;

namespace Ferreteria
{
    class Helper
    {
        public static Empleado loguedUser;

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

        public static bool ymd=true;

        public static string convertDate(string fechaOriginal)
        {/*
          todos los inputs son en formato YYYY-MM-DD HH:MM:SS.mmm o YYYY-MM-DD
          * y se devolvera su resultado con los campos MM y DD intercambiados si ymd es true
          */
            
            Console.WriteLine(fechaOriginal);

            if (ymd)
            {
                Console.WriteLine(fechaOriginal);
                return fechaOriginal;
            }

            string resultado = "";
            if (fechaOriginal.Contains(":"))
            {
                string[] fecha = fechaOriginal.Split(' ')[0].Split('-');
                resultado = fecha[0]+"-"+fecha[2]+"-"+fecha[1]+" "+fechaOriginal.Split(' ')[1];
            }
            else
            {
                string[] fecha = fechaOriginal.Split('-');
                resultado = fecha[0]+"-"+fecha[2]+"-"+fecha[1];
            }
            
            Console.WriteLine(resultado);
            return resultado;
        }

        public static void checkDateFormat(){
            try
            {
                BDHelper.ExcecuteSQL("INSERT INTO pruebaFecha(fecha) VALUES('2018-09-19 14:15:16.789')");
                ymd = true;
            }
            catch
            {
                BDHelper.ExcecuteSQL("INSERT INTO pruebaFecha(fecha) VALUES('2018-19-09 14:15:16.789')");
                ymd = false;
            }
            //BDHelper.ExcecuteSQL("DELETE FROM pruebaFecha");
        }

        //Valida un usuario contra la DB. En caso de ser correcto el legajo y pass devuelve true
        public static bool validarUsuario(string legajo, string pass)
        {
            pass = Helper.sha256(pass);
            DataTable tabla = BDHelper.ConsultaSQL("SELECT * FROM USUARIO WHERE legajo =  \'"
                            + legajo + "\' AND password = \'"
                            + pass + "\' AND activo=1");

            if (tabla.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public static int getSelectedId(DataGridView grid)
        {
            return (getSelectedId(grid, 0));
        }

        //Devuelve el ID de la fila seleccionada en un DataGrid y una celda pasado como parametro
        public static int getSelectedId(DataGridView grid, int cell)
        {
            int id = 0;
            try
            {
                id = (int)grid.SelectedRows[0].Cells[cell].Value;
            }
            catch
            {
                try
                {
                    id = (int)grid.Rows[(int)grid.SelectedCells[0].RowIndex].Cells[cell].Value;
                }
                catch
                {

                }
            }
            return id;
        }

        //Llena el combobox pasado como parametro
        public static void llenarCbo (ComboBox cbo, DataTable t, string d, string v)
        {
            cbo.DataSource = t;
            cbo.DisplayMember = d;
            cbo.ValueMember = v;
            cbo.SelectedIndex = -1;
        }

        //Llena el combobox buscador pasado como parametro
        public static void llenarCboBuscador(ComboBox cbo, DataTable t, string display, string value)
        {
            cbo.DroppedDown = false;
            Helper.llenarCbo(cbo, t, display, value);
            cbo.DroppedDown = true;
            Cursor.Current = Cursors.Default;
        }
    }
}
