using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Ferreteria.Models
{
    class TipoFactura
    {
        public int codigoTipo = 0;
        public string nombre = "";
        public bool activo = true;


        //Constructor nuevo tipo factura
        public TipoFactura(int id, string nombre)
        {
            codigoTipo = id;
            this.nombre = nombre;
        }

        //Constructor tipo factura existente
        public TipoFactura(int id)
        {
            codigoTipo = id;
            readAttrs();
        }

        //Metodo que busca los datos de un tipo de factura
        private void readAttrs()
        {
            DataTable values = BDHelper.ConsultaSQL("SELECT nombre, activo FROM TIPO_FACTURA WHERE codigoTipo = " + codigoTipo);
            nombre = values.Rows[0]["nombre"].ToString();
            activo = (bool)values.Rows[0]["activo"];
        }

        //Metodo que guarda los datos de un tipo de factura nuevo o uno ya existente
        public bool save()
        {
            try
            {
                if (codigoTipo != 0)//Tipo de factura existente
                {
                    BDHelper.ExcecuteSQL("UPDATE TIPO_FACTURA SET nombre = '" + nombre + "', activo = " + getActivo() + " WHERE codigoTipo = " + codigoTipo);
                }
                else//Tipo de factura nuevo
                {
                    BDHelper.ExcecuteSQL("INSERT INTO TIPO_FACTURA( nombre, activo) VALUES('" + nombre + "', " + getActivo() + ")");
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        //Devuelve si el tipo de factura esta activo en el sistema y puede usarse
        private string getActivo()
        {
            if (activo)
                return "1";
            return "0";
        }

        //Modifica el estado del tipo de factura a activo o inactivo según corresponda
        public void available(bool state)
        {
            activo = state;
            BDHelper.ExcecuteSQL("UPDATE TIPO_FACTURA SET activo = " + getActivo() + " WHERE codigoTipo = " + codigoTipo);
        }

        //Devuelve una tabla con todos los tipos de facturas activas del sistema
        public static DataTable GetAllTipoFacturas()
        {
            return BDHelper.ConsultaSQL("SELECT codigoTipo, nombre FROM TIPO_FACTURA WHERE activo = 1 ORDER BY nombre ASC");
        }
    }
}
