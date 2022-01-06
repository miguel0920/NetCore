using Cliente.AbstractFactory.Interfaz;
using System;

namespace Cliente.AbstractFactory.Imple
{
    public class ConexionRestAuthentication : IConexionRest
    {
        public void PeticionGet(string url)
        {
            Console.WriteLine(url);
        }
    }
}