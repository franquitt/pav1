using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Ferreteria.Models
{
    class Empleado
    {
        int legajo=0;
        DateTime fechaIngreso = new DateTime();
        string telefono = "";
        DateTime fechaNacimiento = new DateTime();
        string nombre = "";
        string apellido = "";
        string password = "";
        TipoEmpleado tipo = new TipoEmpleado(0, "");
        DateTime ultimoLogin = new DateTime();
        bool activo = true;
        public Empleado()
        {

        }
        public Empleado(int legajo, DateTime fechaIngreso, string telefono, DateTime fechaNacimiento, string nombre, string apellido, string password, TipoEmpleado tipo, DateTime ultimoLogin, bool activo)
        {
            this.legajo = legajo;
            this.fechaIngreso = fechaIngreso;
            this.telefono = telefono;
            this.fechaNacimiento = fechaNacimiento;
            this.nombre = nombre;
            this.apellido = apellido;
            this.password = password;
            this.tipo = tipo;
            this.ultimoLogin = ultimoLogin;
            this.activo = activo;
        }
        public Empleado(int legajo)
        {
            this.legajo = legajo;
            readAttrs();
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
            string stateStr = "0";
            if(state)
                stateStr = "1";
            BDHelper.ExcecuteSQL("UPDATE USUARIO SET activo = "+stateStr+" WHERE legajo = " + legajo);
        }
        public static DataTable GetAllEmployes() {
            return BDHelper.ConsultaSQL("SELECT legajo AS 'Legajo', USUARIO.nombre, apellido, TIPO_USUARIO.nombre AS 'Tipo de Usuario' FROM USUARIO JOIN TIPO_USUARIO ON(USUARIO.tipo=TIPO_USUARIO.codigoTipo) WHERE activo = 1 ORDER BY apellido, nombre");
        }
    }
}
