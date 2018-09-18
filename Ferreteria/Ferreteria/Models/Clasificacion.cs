using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.Models
{
    class Clasificacion
    {
        public int codigoClasificacion = 0;
        public string nombre = "";
        public bool activo = true;
        public string descripcion = "";


        //Constructor nueva clasificacion
        public Clasificacion(int id, string nombre, string descripcion)
        {
            codigoClasificacion = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        //Constructor clasificacion existente
        public Clasificacion(int id)
        {
            codigoClasificacion = id;
            readAttrs();
        }

        //Metodo que busca los datos de una clasificacion
        private void readAttrs()
        {
            DataTable values = BDHelper.ConsultaSQL("SELECT nombre, descripcion, activo FROM CLASIFICACION WHERE codigoClasificacion = " + codigoClasificacion);
            nombre = values.Rows[0]["nombre"].ToString();
            descripcion = values.Rows[0]["descripcion"].ToString();
            activo = (bool)values.Rows[0]["activo"];
        }

        //Metodo que guarda los datos de una clasificacion nueva o una ya existente
        public bool save()
        {
            try
            {
                if (codigoClasificacion != 0)//Clasificacion existente
                {
                    BDHelper.ExcecuteSQL("UPDATE CLASIFICACION SET nombre = '" + nombre + "', activo = " + getActivo() + ", descripcion = '" + descripcion + "' WHERE codigoClasificacion = " + codigoClasificacion);
                }
                else//Clasificacion nueva
                {
                    BDHelper.ExcecuteSQL("INSERT INTO CLASIFICACION( nombre, activo, descripcion) VALUES('" + nombre + "', " + getActivo() + ", '" + descripcion + "')");
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        //Devuelve si la clasificacion esta activa en el sistema y puede usarse
        private string getActivo()
        {
            if (activo)
                return "1";
            return "0";
        }

        //Modifica el estado de la clasificacion a activa o inactiva según corresponda
        public void available(bool state)
        {
            activo = state;
            BDHelper.ExcecuteSQL("UPDATE CLASIFICACION SET activo = " + getActivo() + " WHERE codigoClasificacion = " + codigoClasificacion);
        }

        //Devuelve una tabla con todas las clasificaciones activas del sistema
        public static DataTable GetAllClasificaciones()
        {
            return BDHelper.ConsultaSQL("SELECT codigoClasificacion, nombre, descripcion FROM CLASIFICACION WHERE activo = 1 ORDER BY nombre ASC");
        }
    }
}
