using System;
using System.Data;
using System.Data.SqlClient;
public static class BDHelper
{
    private static string string_conexion = "Data Source=FRANCOMAIN-PC\\TEW_SQLEXPRESS;Initial Catalog=BugsClase03;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    private static SqlConnection conexion;
    private static SqlCommand cmd;

    private static void Conectar()
    {
        conexion = new SqlConnection();
        conexion.ConnectionString = string_conexion;
        conexion.Open();
        cmd = new SqlCommand();
        cmd.Connection = conexion;
        cmd.CommandType = CommandType.Text;
    }
    private static void Desconectar()
    {
        if ((conexion.State == ConnectionState.Open))
        {
            conexion.Close();
        }

        // Dispose() libera los recursos asociados a la conexón
        conexion.Dispose();
    }

    public static DataTable ConsultaSQL(string strSql)
    {
        Conectar();
        DataTable tabla = new DataTable();
        try
        {
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
            Desconectar();
        }
    }
    public static void ExcecuteSQL(string strSql)
    {
        Conectar();
        try
        {
            cmd.CommandText = strSql;
            //  El datatable se carga con el resultado de ejecutar la sentencia en el motor de base de datos

            cmd.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            Desconectar();
        }
    }
}