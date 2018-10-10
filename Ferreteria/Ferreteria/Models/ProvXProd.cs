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
            return BDHelper.ConsultaSQL("SELECT X.codigoProveedor, X.codigoProducto, X.tiempoEntrega AS 'Tiempo de entrega', X.precio AS 'Precio', P.nombre AS 'Producto', CONCAT(PR.apellido, CONCAT(' ', PR.nombre)) AS 'Proveedro' FROM PROVxPROD X JOIN PRODUCTOS P ON(X.codigoProducto = P.codigoProducto) JOIN PROVEEDOR PR ON(X.codigoProveedor = PR.codigoProveedor)");
        }

        //Metodo que guarda los datos de una asociacion nueva o una ya existente
        public bool save(bool nuevo)
        {
            try
            {
                if (!nuevo)//Asociacion existente
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
