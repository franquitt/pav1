using System.Data;
using System.Windows.Forms;

namespace Ferreteria.Models
{
    class ProvXProd
    {
        public int prov = 0;
        public int prod = 0;
        public int tiempo = 0;
        public decimal precio = 0;

        //Constructor nueva asociacion
        public ProvXProd(int prod, int prov, int tiempo, decimal precio)
        {
            this.prod = prod;
            this.prov = prov;
            this.tiempo = tiempo;
            this.precio = precio;
        }

        //Constructor asociacion existente
        public ProvXProd(int prod, int prov)
        {
            this.prod = prod;
            this.prov = prov;
            readAttrs();
        }

        //Metodo que busca los datos de una asociacion
        private void readAttrs()
        {
            DataTable values = BDHelper.ConsultaSQL("SELECT tiempoEntrega, precio FROM PROVxPROD WHERE  codigoProducto = " + prod + " AND codigoProveedor = " + prov);
            tiempo = int.Parse(values.Rows[0]["tiempoEntrega"].ToString());
            precio = decimal.Parse(values.Rows[0]["precio"].ToString());
        }

        //Devuelve una tabla con todas las asociaciones del sistema
        public static DataTable GetAllProvProd()
        {
            return BDHelper.ConsultaSQL("SELECT X.codigoProveedor, X.codigoProducto, X.tiempoEntrega AS 'Tiempo de entrega', X.precio AS 'Precio', P.nombre AS 'Producto', CONCAT(PR.apellido, CONCAT(' ', PR.nombre)) AS 'Proveedor' FROM PROVxPROD X JOIN PRODUCTOS P ON(X.codigoProducto = P.codigoProducto) JOIN PROVEEDOR PR ON(X.codigoProveedor = PR.codigoProveedor)");
        }
        
        //Devuelve una tabla con los productos que tienen algun proveedor
        public static DataTable GetAllProd()
        {
            return BDHelper.ConsultaSQL("SELECT DISTINCT X.codigoProducto AS 'codProducto', P.nombre AS 'nombre' FROM PROVxPROD X JOIN PRODUCTOS P ON(X.codigoProducto = P.codigoProducto)");
        }

        //Devuelve una tabla con los productos que tienen algun proveedor y cierto nombre
        public static DataTable GetAllProd(string name)
        {
            return BDHelper.ConsultaSQL("SELECT DISTINCT X.codigoProducto AS 'codProducto', P.nombre AS 'nombre' FROM PROVxPROD X JOIN PRODUCTOS P ON(X.codigoProducto = P.codigoProducto) WHERE nombre LIKE '%" + name + "%'");
        }

        //Devuelve una tabla con los proveedores que venden cierto producto
        public static DataTable GetAllProveedoresByProducto(int cod)
        {
            return BDHelper.ConsultaSQL("SELECT P.codigoProveedor AS 'codigoProveedor', CONCAT(P.apellido, CONCAT(' ', P.nombre)) AS 'fullname' " +
                "FROM PROVEEDOR P JOIN PROVxPROD PR ON(PR.codigoProducto = " + cod + " AND P.codigoProveedor = PR.codigoProveedor) " +
                "WHERE P.activo = 1");
        }

        //Devuelve una tabla con los proveedores que venden cierto producto
        public static bool ExisteAsociacion(int prod, int prov)
        {
            DataTable t = BDHelper.ConsultaSQL("SELECT * FROM PROVxPROD WHERE codigoProveedor = " + prov + "AND codigoProducto = " + prod);
            if (t.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        //Metodo que guarda los datos de una asociacion nueva o una ya existente
        public bool save(bool nuevo)
        {
            try
            {
                if(!nuevo)//Asociacion existente
                {
                    BDHelper.ExcecuteSQL("UPDATE PROVxPROD SET codigoProveedor = " + prov + ", codigoProducto = " + prod + ", tiempoEntrega = " + tiempo + ", precio = " + precio.ToString().Replace(",", ".") + " WHERE codigoProveedor = " + prov + "AND codigoProducto = " + prod);
                }
                else//Asociacion nueva
                {
                    BDHelper.ExcecuteSQL("INSERT INTO PROVxPROD( codigoProveedor, codigoProducto, tiempoEntrega, precio) VALUES(" + prov + ", " + prod + ", " + tiempo + ", " + precio.ToString().Replace(",", ".") + ")");
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        //Metodo que borra una asociacion
        public bool delete()
        {
            try
            {
                BDHelper.ExcecuteSQL("DELETE FROM PROVxPROD WHERE codigoProveedor = " + prov + "AND codigoProducto = " + prod);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
