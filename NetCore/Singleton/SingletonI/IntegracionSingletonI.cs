using Singleton.SingletonI.Implementacion;
using System;

namespace Singleton.SingletonI
{
    public class IntegracionSingletonI
    {
        public static void IntegracionSingletonIConsole()
        {
            Conexion conexion = Conexion.GetInstancia();
            conexion.ConexionDB();
            conexion.Desconexion();
            bool isObject = conexion is Conexion;
            Console.WriteLine(isObject);
        }
    }
}