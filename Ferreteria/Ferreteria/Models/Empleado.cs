using System;
using System.Data;
namespace Ferreteria.Models
{
    class Empleado
    {
        public int legajo = 0;
        public DateTime fechaIngreso = new DateTime();
        public string telefono = "";
        public DateTime fechaNacimiento = new DateTime();
        public string nombre = "";
        public string apellido = "";
        public string password = "";
        public TipoEmpleado tipo = new TipoEmpleado(0, "");
        public DateTime ultimoLogin = new DateTime();
        public bool activo = true;

        public Empleado()
        {

        }

        public Empleado(DateTime fechaIngreso, string telefono, DateTime fechaNacimiento, string nombre, string apellido, string password, TipoEmpleado tipo, DateTime ultimoLogin, bool activo)
        {
            this.fechaIngreso = fechaIngreso;
            this.telefono = telefono;
            this.fechaNacimiento = fechaNacimiento;
            this.nombre = nombre;
            this.apellido = apellido;
            this.password = Helper.sha256(password);
            this.tipo = tipo;
            this.ultimoLogin = ultimoLogin;
            this.activo = activo;
        }

        public Empleado(int legajo, DateTime fechaIngreso, string telefono, DateTime fechaNacimiento, string nombre, string apellido, string password, TipoEmpleado tipo, DateTime ultimoLogin, bool activo)
        {
            this.legajo = legajo;
            this.fechaIngreso = fechaIngreso;
            this.telefono = telefono;
            this.fechaNacimiento = fechaNacimiento;
            this.nombre = nombre;
            this.apellido = apellido;
            if(!password.Equals(""))
                this.password = Helper.sha256(password);
            this.tipo = tipo;
            this.ultimoLogin = ultimoLogin;
            this.activo = activo;
        }

        public Empleado(int legajo)
        {
            this.legajo = legajo;
            readAttrs();
        }

        public bool save()
        {
            try
            {

                if (legajo == 0)
                    BDHelper.ExcecuteSQL("INSERT INTO USUARIO(fechaIngreso, telefono, fechaNacimiento, nombre, apellido, password, tipo, ultimoLogin, activo) VALUES('" + fechaIngreso.ToString("yyyy-MM-dd") + "', '" + telefono + "', '" + fechaNacimiento.ToString("yyyy-MM-dd") + "', '" + nombre + "', '" + apellido + "', '" + password + "', " + tipo.codigoTipo + ", '" + Helper.convertDate(ultimoLogin.ToString("yyyy-MM-dd HH:mm:ss.fff")) + "', " + getActivo() + ")");
                else
                    if(!password.Equals(""))
                        BDHelper.ExcecuteSQL("UPDATE USUARIO SET fechaIngreso = '" + fechaIngreso.ToString("yyyy-MM-dd") + "', telefono = '" + telefono + "', fechaNacimiento = '" + fechaNacimiento.ToString("yyyy-MM-dd") + "', nombre = '" + nombre + "', apellido = '" + apellido + "', password = '" + password + "', tipo = " + tipo.codigoTipo + ", ultimoLogin = '" + Helper.convertDate(ultimoLogin.ToString("yyyy-MM-dd HH:mm:ss.fff")) + "', activo = " + getActivo() + " WHERE legajo = " + legajo);
                    else
                        BDHelper.ExcecuteSQL("UPDATE USUARIO SET fechaIngreso = '" + fechaIngreso.ToString("yyyy-MM-dd") + "', telefono = '" + telefono + "', fechaNacimiento = '" + fechaNacimiento.ToString("yyyy-MM-dd") + "', nombre = '" + nombre + "', apellido = '" + apellido + "', tipo = " + tipo.codigoTipo + ", ultimoLogin = '" + Helper.convertDate(ultimoLogin.ToString("yyyy-MM-dd HH:mm:ss.fff")) + "', activo = " + getActivo() + " WHERE legajo = " + legajo);

            }
            catch(Exception ex)
            {
                throw ex;
            }
            return true;
        }

        private void readAttrs()
        {
            DataTable values = BDHelper.ConsultaSQL("SELECT fechaIngreso, telefono, fechaNacimiento, nombre, apellido, password, tipo, ultimoLogin, activo FROM USUARIO WHERE legajo = "+legajo);
            fechaIngreso = DateTime.Parse(values.Rows[0]["fechaIngreso"].ToString());
            telefono = values.Rows[0]["telefono"].ToString();
            fechaNacimiento = DateTime.Parse(values.Rows[0]["fechaNacimiento"].ToString());
            nombre = values.Rows[0]["nombre"].ToString();
            apellido = values.Rows[0]["apellido"].ToString();
            password = values.Rows[0]["password"].ToString();
            tipo = new TipoEmpleado((int)values.Rows[0]["tipo"]);
            ultimoLogin = DateTime.Parse(values.Rows[0]["ultimoLogin"].ToString());
            activo = (bool) values.Rows[0]["activo"];
        }

        public void available(bool state)
        {
            activo = state;
            BDHelper.ExcecuteSQL("UPDATE USUARIO SET activo = "+ getActivo() + " WHERE legajo = " + legajo);
        }

        public static DataTable GetAllEmployes()
        {
            return BDHelper.ConsultaSQL("SELECT legajo AS 'Legajo', CONCAT(USUARIO.apellido, CONCAT(' ', USUARIO.nombre)) AS 'Nombre', TIPO_USUARIO.nombre AS 'Tipo de Usuario' FROM USUARIO JOIN TIPO_USUARIO ON(USUARIO.tipo=TIPO_USUARIO.codigoTipo) WHERE USUARIO.activo = 1 ORDER BY apellido, nombre");
        }

        private string getActivo()
        {
            if (activo)
                return"1";
            return "0";
        }
    }
}
