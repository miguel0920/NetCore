using DPT.Factory_Pattern.Interfaz;
using System;

namespace DPT.Factory_Pattern.Imple
{
    public class ConexionVacia : IConexion
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