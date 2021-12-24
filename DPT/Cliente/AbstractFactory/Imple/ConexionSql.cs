using Cliente.AbstractFactory.Interfaz;
using System;

namespace Cliente.AbstractFactory.Imple
{
    public class ConexionSql : IConexionBD
    {
        private string _host;
        private string _port;
        private string _user;
        private string _password;

        public ConexionSql()
        {
            _host = "localhost";
            _port = "1600";
            _user = "root";
            _password = "321";
        }

        public void Conexion()
        {
            Console.WriteLine("Conexión Sql");
        }

        public void Desconexion()
        {
            Console.WriteLine("Desconexión Sql");
        }
    }
}
