﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace Ferreteria
{
    class Helper
    {
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
        public static bool validarUsuario(string legajo, string pass)
        {
            pass = Helper.sha256(pass);
            DataTable tabla = BDHelper.ConsultaSQL("SELECT * FROM USUARIOS WHERE legajo =  \'"
                            + legajo + "\' AND password = \'"
                            + pass + "\'");


            if (tabla.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
