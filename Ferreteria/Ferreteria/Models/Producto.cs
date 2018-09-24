using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ferreteria.Models;

namespace Ferreteria.Models
{
    class Producto
    {
        public int codigoProducto = 0;
        public string nombre = "";
        public string descripcion = "";
        public decimal precio = 0;
        public int codigoClasificacion = 0;
        public bool activo = true;
        public Clasificacion clasificacion = null;

        public Producto(int id)
        {
            this.codigoProducto = id;
            readAttrs();
        }

        public Producto() { }

        public Producto(int id, string nombre, decimal precio, string descripcion, int codigoClasificacion)
        {
            this.codigoProducto = id;
            this.nombre = nombre;
            this.precio = precio;
            this.descripcion = descripcion;
            this.codigoClasificacion = codigoClasificacion;
        }

        public void readAttrs()
        {
            DataTable values = BDHelper.ConsultaSQL("SELECT nombre, descripcion, precio, clasificacion, activo FROM PRODUCTOS WHERE codigoProducto = " + codigoProducto);
            nombre = values.Rows[0]["nombre"].ToString();
            descripcion = values.Rows[0]["descripcion"].ToString();
            precio = (decimal)values.Rows[0]["precio"];
            codigoClasificacion = (int)values.Rows[0]["clasificacion"];
            activo = (bool)values.Rows[0]["activo"];
            clasificacion = new Clasificacion(codigoClasificacion);
        }

        public bool save()
        {
            try
            {
                if (codigoProducto != 0)//Producto existente
                {
                    BDHelper.ExcecuteSQL("UPDATE PRODUCTOS SET nombre = '" + nombre + "', activo = " + getActivo() + ", precio = " + precio.ToString().Replace(",", ".") + ", descripcion = '" + descripcion + "', clasificacion = " + codigoClasificacion + " WHERE codigoProducto = " + codigoProducto);
                }
                else//Producto nuevo
                {
                    BDHelper.ExcecuteSQL("INSERT INTO PRODUCTOS(nombre, activo, descripcion, precio, clasificacion) VALUES('" + nombre + "', " + getActivo() + ", '" + descripcion + "', " + precio.ToString().Replace(",", ".") + ", " + codigoClasificacion + ")");
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public void available(bool state)
        {
            activo = state;
            BDHelper.ExcecuteSQL("UPDATE PRODUCTOS SET activo = " + getActivo() + " WHERE codigoProducto = " + codigoProducto);
        }

        public static DataTable GetAllProductos()
        {
            return BDHelper.ConsultaSQL("" +
                "SELECT PRODUCTOS.codigoProducto AS 'Codigo', PRODUCTOS.nombre AS 'Nombre', PRODUCTOS.descripcion as 'Descripcion', PRODUCTOS.precio as 'Precio', CLASIFICACION.nombre AS 'Clasificacion' " +
                "FROM PRODUCTOS JOIN CLASIFICACION ON(PRODUCTOS.clasificacion=CLASIFICACION.codigoClasificacion) " +
                "WHERE PRODUCTOS.activo = 1 ORDER BY nombre");
        }

        private string getActivo()
        {
            if (activo)
                return "1";
            return "0";
        }
    }
}
