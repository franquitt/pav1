using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.Models
{
    class Lote
    {
        public int nroLote = 0;
        public int codigoProveedor = 0;
        public int codigoProducto = 0;
        public int stockInicial = 0;
        public int stockActual = 0;
        public DateTime fechaIngreso = new DateTime();
        public Lote(int nroLote)
        {
            this.nroLote = nroLote;
            readAttrs();
        }
        public void readAttrs()
        {
            DataTable values = BDHelper.ConsultaSQL("SELECT codigoProveedor, codigoProducto, stockInicial, stockActual, fechaIngreso FROM LOTES WHERE numeroLote = " + nroLote);
            codigoProveedor = (int)values.Rows[0]["codigoProveedor"];
            codigoProducto = (int)values.Rows[0]["codigoProducto"];
            stockInicial = (int)values.Rows[0]["stockInicial"];
            stockActual = (int)values.Rows[0]["stockActual"];
            fechaIngreso = DateTime.Parse(values.Rows[0]["fechaIngreso"].ToString());
        }
        public static DataTable getAllLotes() {
            return BDHelper.ConsultaSQL("SELECT LOTES.numeroLote, PROVEEDOR.nombre AS nomProveedor, PRODUCTOS.nombre AS nomProducto, LOTES.stockActual, LOTES.fechaIngreso FROM LOTES JOIN PROVEEDOR ON(PROVEEDOR.codigoProveedor = LOTES.codigoProveedor) JOIN PRODUCTOS ON(PRODUCTOS.codigoProducto = LOTES.codigoProducto)");
        }
    }
}
