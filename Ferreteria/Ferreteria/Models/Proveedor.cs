using System;
using System.Data;

namespace Ferreteria.Models
{
    class Proveedor
    {
        public int codigoProveedor = 0;
        public string nombre = "";
        public string apellido = "";
        public string direccion = "";
        public string telefono = "";
        public bool activo = true;

        public Proveedor(int codigoProveedor, string nombre, string apellido, string direccion, string telefono)
        {
            this.codigoProveedor = codigoProveedor;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefono = telefono;
        }

        public Proveedor(int codigoProveedor)
        {
            this.codigoProveedor = codigoProveedor;
            buscarDatosProveedor(codigoProveedor);
        }

        private void buscarDatosProveedor(int codigoProveedor)
        {
            DataTable tabla = BDHelper.ConsultaSQL("SELECT nombre, apellido, direccion, telefono, activo FROM PROVEEDOR WHERE codigoProveedor= " + codigoProveedor );
            nombre = tabla.Rows[0]["nombre"].ToString();
            apellido = tabla.Rows[0]["apellido"].ToString();
            direccion = tabla.Rows[0]["direccion"].ToString();
            telefono = tabla.Rows[0]["telefono"].ToString();
            activo = (bool)tabla.Rows[0]["activo"];
        }

        public static DataTable GetAllProveedores()
        {
            return BDHelper.ConsultaSQL("SELECT codigoProveedor AS '#', nombre AS 'Nombre', apellido AS 'Apellido', direccion AS 'Dirección', telefono AS 'Teléfono' FROM PROVEEDOR WHERE activo = 1");
        }

        public static DataTable GetAllNames()
        {
            return BDHelper.ConsultaSQL("SELECT codigoProveedor, CONCAT(apellido, CONCAT(' ', nombre)) AS 'fullname' FROM PROVEEDOR WHERE activo = 1");
        }

        public static DataTable GetAllProveedoresByName(string str)
        {
            return BDHelper.ConsultaSQL("SELECT codigoProveedor, CONCAT(apellido, CONCAT(' ', nombre)) AS 'fullname' FROM PROVEEDOR WHERE activo = 1 AND nombre LIKE '%" + str + "%' OR apellido LIKE '%" + str + "%'");
        }

        public bool save()
        {
            try
            {
                if (codigoProveedor == 0)
                    BDHelper.ExcecuteSQL("INSERT INTO PROVEEDOR(nombre, apellido, direccion, telefono, activo) " +
                                    "VALUES('" + nombre + "', '" + apellido + "', '" + direccion + "', '" + telefono + "', '" + getActivo() + "')");
                else
                {
                    BDHelper.ExcecuteSQL("UPDATE PROVEEDOR SET nombre = '" + nombre + "', apellido = '" + apellido + "', direccion = '" + direccion + "', telefono = '" + telefono + "', activo = '" + getActivo() + "' WHERE codigoProveedor = " + codigoProveedor);
                }
            }
            catch (Exception ex)
            {
                throw ex;
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
            BDHelper.ExcecuteSQL("UPDATE PROVEEDOR SET activo = " + getActivo() + " WHERE codigoProveedor = " + codigoProveedor);
        }

    }
}
