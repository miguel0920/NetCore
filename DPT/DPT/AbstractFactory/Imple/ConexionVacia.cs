using DPT.AbstractFactory.Interfaz;
using System;

namespace DPT.AbstractFactory.Imple
{
    public class ConexionVacia : IConexionBD
    {
        public void Conexion()
        {
            Console.WriteLine("Conexión no especificada");
        }

        public void Desconexion()
        {
            Console.WriteLine("Desconexión no especificada");
        }
    }
}
