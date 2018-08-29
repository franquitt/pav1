using System;
using System.Data;
using System.Data.SqlClient;
public class BDHelper
{
    private static BDHelper instance; //Unica instancia de la clase
    private string string_conexion = "Data Source=FRANCOMAIN-PC\\TEW_SQLEXPRESS;Initial Catalog=BugsClase03;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

    public static BDHelper getDBHelper()
    {
        if (instance != null)
            instance = new BDHelper();
        return instance;
    }

    public DataTable ConsultaSQL(string strSql)
    {
        //  Se utiliza para sentencias SQL del tipo Select
        //  La función recibe por valor una sentencia sql como string, devuelve un objeto de tipo DataTable
        SqlConnection conexion = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DataTable tabla = new DataTable();
        try
        {
            conexion.ConnectionString = string_conexion;
            conexion.Open();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strSql;
            //  El datatable se carga con el resultado de ejecutar la sentencia en el motor de base de datos

            tabla.Load(cmd.ExecuteReader());
            //  La funcion retorna el objeto datatable con 0, 1 o mas registros
            return tabla;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            if ((conexion.State == ConnectionState.Open))
            {
                conexion.Close();
            }

            // Dispose() libera los recursos asociados a la conexón
            conexion.Dispose();
        }

    }
}