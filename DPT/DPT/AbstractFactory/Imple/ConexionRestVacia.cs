using DPT.AbstractFactory.Interfaz;
using System;

namespace DPT.AbstractFactory.Imple
{
    public class ConexionRestVacia : IConexionRest
    {
        public void PeticionGet(string url)
        {
            Console.WriteLine("Url no encontrada");
        }
    }
}
