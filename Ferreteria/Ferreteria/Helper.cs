using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Console.WriteLine("SELECT * FROM USUARIO WHERE legajo =  \'"
                            + legajo + "\' AND password = \'"
                            + pass + "\'");
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

        //Llena el combobox pasado como parametro
        public static void llenarCbo (ComboBox cbo, DataTable t, string d, string v)
        {
            cbo.DataSource = t;
            cbo.DisplayMember = d;
            cbo.ValueMember = v;
            cbo.SelectedIndex = -1;
        }
    }
}
