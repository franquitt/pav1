﻿using System.Data;

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
        public int stock =0;

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
            DataTable values = BDHelper.ConsultaSQL("SELECT nombre, descripcion, precio, clasificacion, activo, stocky.stocp FROM PRODUCTOS LEFT JOIN (SELECT SUM(stockActual) stocp, codigoProducto FROM LOTES WHERE LOTES.codigoProducto = " + codigoProducto + " GROUP BY codigoProducto) as stocky ON (stocky.codigoProducto = PRODUCTOS.codigoProducto) WHERE PRODUCTOS.codigoProducto = " + codigoProducto);
            nombre = values.Rows[0]["nombre"].ToString();
            descripcion = values.Rows[0]["descripcion"].ToString();
            precio = (decimal)values.Rows[0]["precio"];
            codigoClasificacion = (int)values.Rows[0]["clasificacion"];
            activo = (bool)values.Rows[0]["activo"];
            try
            {
                stock = (int)values.Rows[0]["stocp"];
            }
            catch
            {

            }
            clasificacion = new Clasificacion(codigoClasificacion);
        }

        public bool Save()
        {
            try
            {
                if (codigoProducto != 0)//Producto existente
                {
                    BDHelper.ExcecuteSQL("UPDATE PRODUCTOS SET nombre = '" + nombre + "', activo = " + GetActivo() + ", precio = " + precio.ToString().Replace(",", ".") + ", descripcion = '" + descripcion + "', clasificacion = " + codigoClasificacion + " WHERE codigoProducto = " + codigoProducto);
                }
                else//Producto nuevo
                {
                    BDHelper.ExcecuteSQL("INSERT INTO PRODUCTOS(nombre, activo, descripcion, precio, clasificacion) VALUES('" + nombre + "', " + GetActivo() + ", '" + descripcion + "', " + precio.ToString().Replace(",", ".") + ", " + codigoClasificacion + ")");
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
            BDHelper.ExcecuteSQL("UPDATE PRODUCTOS SET activo = " + GetActivo() + " WHERE codigoProducto = " + codigoProducto);
        }

        public static DataTable GetAllProductos()
        {
            return BDHelper.ConsultaSQL("" +
                "SELECT PRODUCTOS.codigoProducto AS '#', PRODUCTOS.nombre AS 'Nombre', PRODUCTOS.descripcion as 'Descripcion', PRODUCTOS.precio as 'Precio', CLASIFICACION.nombre AS 'Clasificacion', SUM(LOTES.stockActual) AS 'Stock'" +
                "FROM PRODUCTOS " +
                "JOIN CLASIFICACION ON(PRODUCTOS.clasificacion = CLASIFICACION.codigoClasificacion)" +
                "JOIN LOTES ON(LOTES.codigoProducto = PRODUCTOS.codigoProducto)" +
                "WHERE PRODUCTOS.activo = 1" +
                "GROUP BY PRODUCTOS.codigoProducto, PRODUCTOS.nombre, PRODUCTOS.descripcion, PRODUCTOS.precio, CLASIFICACION.nombre " +
                "ORDER BY PRODUCTOS.nombre");
        }

        public static DataTable GetAllProductosByName(string name)
        {
            return BDHelper.ConsultaSQL("" +
                "SELECT codigoProducto, nombre FROM PRODUCTOS WHERE PRODUCTOS.activo = 1 AND nombre LIKE '%" + name + "%'");
        }

        public static DataTable GetNames()
        {
            return BDHelper.ConsultaSQL("SELECT codigoProducto, nombre FROM PRODUCTOS WHERE PRODUCTOS.activo = 1");
        }

        private string GetActivo()
        {
            if (activo)
                return "1";
            return "0";
        }
    }
}
