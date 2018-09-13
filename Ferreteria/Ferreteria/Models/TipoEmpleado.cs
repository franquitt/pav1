using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Ferreteria.Models
{
    class TipoEmpleado
    {
        public int codigoTipo = 0;
        public string nombre="";
        public bool activo = true;
        public TipoEmpleado(int id, string nombre)
        {
            codigoTipo = id;
            this.nombre = nombre;
        }
        public TipoEmpleado(int id)
        {
            codigoTipo = id;
            readAttrs();
        }

        private void readAttrs()
        {
            DataTable values = BDHelper.ConsultaSQL("SELECT nombre, activo FROM TIPO_USUARIO WHERE codigoTipo = " + codigoTipo);
            nombre = values.Rows[0]["nombre"].ToString();
            activo = (bool)values.Rows[0]["activo"];
        }

        public bool save()
        {
            try
            {
                if (codigoTipo != 0)//es viejo
                {
                    BDHelper.ExcecuteSQL("UPDATE TIPO_USUARIO SET nombre = '" + nombre + "', activo = "+ getActivo() + " WHERE codigoTipo = " + codigoTipo);
                }
                else
                {
                    BDHelper.ExcecuteSQL("INSERT INTO TIPO_USUARIO( nombre, activo) VALUES('" + nombre + "', "+ getActivo() + ")");
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        private string getActivo()
        {
            if (activo)
                return "1";
            return "0";
        }
        public void available(bool state)
        {
            activo = state;
            BDHelper.ExcecuteSQL("UPDATE TIPO_USUARIO SET activo = " + getActivo() + " WHERE codigoTipo = " + codigoTipo);
        }
        public static DataTable GetAllUsersTypes()
        {
            return BDHelper.ConsultaSQL("SELECT codigoTipo, nombre FROM TIPO_USUARIO WHERE activo = 1 ORDER BY nombre ASC");
        }
    }
}
