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


        //Constructor nuevo tipo empleado
        public TipoEmpleado(int id, string nombre)
        {
            codigoTipo = id;
            this.nombre = nombre;
        }

        //Constructor tipo empleado existente
        public TipoEmpleado(int id)
        {
            codigoTipo = id;
            readAttrs();
        }

        //Metodo que busca los datos de un tipo de empleado
        private void readAttrs()
        {
            DataTable values = BDHelper.ConsultaSQL("SELECT nombre, activo FROM TIPO_USUARIO WHERE codigoTipo = " + codigoTipo);
            nombre = values.Rows[0]["nombre"].ToString();
            activo = (bool)values.Rows[0]["activo"];
        }

        //Metodo que guarda los datos de un tipo de empleado nuevo o uno ya existente
        public bool save()
        {
            try
            {
                if (codigoTipo != 0)//Tipo de empleado existente
                {
                    BDHelper.ExcecuteSQL("UPDATE TIPO_USUARIO SET nombre = '" + nombre + "', activo = "+ getActivo() + " WHERE codigoTipo = " + codigoTipo);
                }
                else//Tipo de empleado nuevo
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
        
        //Devuelve si el tipo de empleado esta activo en el sistema y puede usarse
        private string getActivo()
        {
            if (activo)
                return "1";
            return "0";
        }
        
        //Modifica el estado del tipo de empleado a activo o inactivo según corresponda
        public void available(bool state)
        {
            activo = state;
            BDHelper.ExcecuteSQL("UPDATE TIPO_USUARIO SET activo = " + getActivo() + " WHERE codigoTipo = " + codigoTipo);
        }

        //Devuelve una tabla con todos los tipos de usuario del sistema
        public static DataTable GetAllUserTypes()
        {
            return BDHelper.ConsultaSQL("SELECT codigoTipo, nombre FROM TIPO_USUARIO WHERE activo = 1 ORDER BY nombre ASC");
        }
    }
}
