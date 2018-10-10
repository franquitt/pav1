using System;
using System.Data;

namespace Ferreteria.Models
{
    class Cliente
    {
        public int codigoCliente = 0;
        public string nombre = "";
        public string apellido = "";
        public string telefono = "";
        public string cuit = "";

        public Cliente(int codigoCliente, string nombre, string apellido, string telefono, string cuit)
        {
            this.codigoCliente = codigoCliente;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.cuit = cuit;
        }

        public Cliente(int codigoCliente)
        {
            this.codigoCliente = codigoCliente;
            buscarDatosCliente(codigoCliente);
        }

        private void buscarDatosCliente(int codigoCliente)
        {
            DataTable values = BDHelper.ConsultaSQL("SELECT codigoCliente, nombre, apellido, telefono, cuit FROM CLIENTES WHERE codigoCliente = " + codigoCliente);
            telefono = values.Rows[0]["telefono"].ToString();
            nombre = values.Rows[0]["nombre"].ToString();
            apellido = values.Rows[0]["apellido"].ToString();
            cuit = values.Rows[0]["cuit"].ToString();
        }

        public static DataTable GetAllClientes()
        {
            return BDHelper.ConsultaSQL("SELECT codigoCliente AS '#', nombre AS 'Nombre', apellido AS 'Apellido', telefono AS 'Teléfono', cuit AS 'CUIT' FROM CLIENTES");
        }

        public static DataTable GetClientesByName(string str, bool name)
        {
            string sql = "SELECT codigoCliente, CONCAT(apellido, CONCAT(' ', nombre)) AS 'fullname', cuit FROM CLIENTES WHERE";
            if (name)
            {
                sql += " nombre LIKE '%" + str + "%' OR apellido LIKE '%" + str + "%'";
            } else
            {
                sql += " cuit LIKE '" + str + "%'";
            }
            return BDHelper.ConsultaSQL(sql);
        }

        public bool save()
        {
            try
            {
                if (codigoCliente == 0)
                    BDHelper.ExcecuteSQL("INSERT INTO CLIENTES(nombre, apellido, telefono, cuit) " +
                        "VALUES('" + nombre + "', '" + apellido + "', '" + telefono + "', '" + cuit + "')");
                else
                {
                    BDHelper.ExcecuteSQL("UPDATE CLIENTES SET nombre = '" + nombre + "', apellido = '" + apellido + "', telefono = '" + telefono + "', cuit = '" + cuit + "' WHERE codigoCliente = " + codigoCliente);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }
    }
}
