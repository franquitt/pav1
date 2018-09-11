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
        int codigoTipo = 0;
        string nombre="";
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
            DataTable values = BDHelper.ConsultaSQL("SELECT nombre FROM TIPO_USUARIO WHERE codigoTipo = " + codigoTipo);
            nombre = values.Rows[0]["nombre"].ToString();
        }
            public void save()
        {
            if (codigoTipo != 0)//es viejo
            {
                BDHelper.ExcecuteSQL("UPDATE TIPO_USUARIO SET nombre = '"+ nombre + "' WHERE codigoTipo = "+codigoTipo);
            }
            else{
                BDHelper.ExcecuteSQL("INSERT INTO TIPO_USUARIO( nombre) VALUES('" + nombre + "')");
            }
        }
        public static DataTable GetAllUsersTypes()
        {
            return BDHelper.ConsultaSQL("SELECT codigoTipo, nombre FROM TIPO_USUARIO ORDER BY nombre ASC");
        }
    }
}
