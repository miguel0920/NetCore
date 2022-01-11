using System;

namespace SOLID.Interface.Wrong
{
    public class Multisencillo : IMultifuncional
    {
        public void Escanear()
        {
            Console.WriteLine("Escaneo tu documento");
        }

        public void Faxear()
        {
            throw new NotImplementedException();
        }

        public void Imprimir()
        {
            Console.WriteLine("Imprimo tu documento");
        }

        public void Telefono()
        {
            throw new NotImplementedException();
        }
    }
}