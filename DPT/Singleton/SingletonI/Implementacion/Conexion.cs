using System;

namespace Singleton.SingletonI.Implementacion
{
    public class Conexion
    {
        private static Conexion instancia;

        private Conexion() { }

        public static Conexion GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new Conexion();
            }
            return instancia;
        }

        public void Desconexion()
        {
            Console.WriteLine("Desconexión exitosa");
        }

        public void ConexionDB()
        {
            Console.WriteLine("Conexión Exitosa");
        }
    }
}