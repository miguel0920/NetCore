using DPT.AbstractFactory.Interfaz;
using System;

namespace DPT.AbstractFactory.Imple
{
    public class ConexionRestAuthentication : IConexionRest
    {
        public void PeticionGet(string url)
        {
            Console.WriteLine(url);
        }
    }
}