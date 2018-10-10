using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

public static class BDHelper
{
    //private static string string_conexion = "Data Source=FRANCOMAIN-PC\\TEW_SQLEXPRESS;Initial Catalog=BugsClase03;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    private static string string_conexion = "Data Source=AGUSVENTURI;Initial Catalog=ProyPav;Integrated Security=True";
    //private static string string_conexion = "Data Source=MAQUIS;Initial Catalog=ProyPav;User ID=avisuales1;Password=avisuales1";
    //private static string string_conexion = "Data Source=.;Initial Catalog = ProyPav; Integrated Security = True";
    private static SqlConnection conexion;
    private static SqlCommand cmd;

    //Se conecta a la DB especificada en el string de conexion y crea el comando SQL en modo texto
    private static void Conectar()
    {
        conexion = new SqlConnection
        {
            ConnectionString = string_conexion
        };
        conexion.Open();
        cmd = new SqlCommand
        {
            Connection = conexion,
            CommandType = CommandType.Text
        };
    }

    //Se desconecta de la DB una vez que se termina de usar
    private static void Desconectar()
    {
        if ((conexion.State == ConnectionState.Open))
        {
            conexion.Close();
        }

        // Dispose() libera los recursos asociados a la conexón
        conexion.Dispose();
    }

    //Ejecuta una consulta SQL (SELECT)
    public static DataTable ConsultaSQL(string strSql)
    {
        Conectar();
        DataTable tabla = new DataTable();
        // Se usa un try-catch en caso que la consulta no se pueda ejecutar. Al terminar se desconecta
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

    //Ejecuta una query (UPDATE, INSERT)
    public static void ExcecuteSQL(string strSql)
    {
        Conectar();
        // Se usa un try-catch en caso que la query no se pueda ejecutar. Al terminar se desconecta
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