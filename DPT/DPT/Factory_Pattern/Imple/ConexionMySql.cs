using DPT.Factory_Pattern.Interfaz;
using System;

namespace DPT.Factory_Pattern.Imple
{
    public class ConexionMySql : IConexion
    {
        private string _host;
        private string _port;
        private string _user;
        private string _password;

        public ConexionMySql()
        {
            _host = "localhost";
            _port = "1500";
            _user = "root";
            _password = "123";
        }

        public void Conexion()
        {
            Console.WriteLine("Conexión MySql");
        }

        public void Desconexion()
        {
            Console.WriteLine("Desconexión MySql");
        }
    }
}