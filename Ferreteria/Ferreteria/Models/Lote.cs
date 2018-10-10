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
        public Lote()
        {
        }

        public void save()
        {
            if (nroLote == 0)
                BDHelper.ExcecuteSQL("INSERT INTO LOTES(codigoProveedor, codigoProducto, stockInicial, stockActual, fechaIngreso) VALUES("+codigoProveedor+", "+codigoProducto+", "+stockInicial+", "+stockActual+", '"+fechaIngreso+"')");
            else
                BDHelper.ExcecuteSQL("UPDATE LOTES SET codigoProveedor = " + codigoProveedor + ", codigoProducto = " + codigoProducto + ", stockInicial = " + stockInicial + ", stockActual = " + stockActual + ", fechaIngreso = '" + fechaIngreso + "' WHERE numeroLote = "+ nroLote+"");
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
            return BDHelper.ConsultaSQL("SELECT LOTES.numeroLote, PROVEEDOR.nombre AS nomProveedor, PRODUCTOS.nombre AS nomProducto, LOTES.stockActual, LOTES.fechaIngreso FROM LOTES JOIN PROVEEDOR ON(PROVEEDOR.codigoProveedor = LOTES.codigoProveedor) JOIN PRODUCTOS ON(PRODUCTOS.codigoProducto = LOTES.codigoProducto) ORDER BY LOTES.fechaIngreso");
        }
        public static Lote[] getAllLotesObjectsByProduct(int codProd)
        {
            DataTable values =  BDHelper.ConsultaSQL("SELECT numeroLote, codigoProveedor, codigoProducto, stockInicial, stockActual, fechaIngreso FROM LOTES WHERE codigoProducto = "+ codProd + " ORDER BY fechaIngreso ASC");
            Lote[] lotes = new Lote[values.Rows.Count];
            for(int index = 0;index < values.Rows.Count; index++)
            {
                lotes[index] = new Lote();
                lotes[index].nroLote = (int)values.Rows[index]["numeroLote"];
                lotes[index].codigoProveedor = (int)values.Rows[index]["codigoProveedor"];
                lotes[index].codigoProducto = (int)values.Rows[index]["codigoProducto"];
                lotes[index].stockInicial = (int)values.Rows[index]["stockInicial"];
                lotes[index].stockActual = (int)values.Rows[index]["stockActual"];
                lotes[index].fechaIngreso = DateTime.Parse(values.Rows[index]["fechaIngreso"].ToString());

            }
            return lotes;
        }
    }
}
