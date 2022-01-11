using System;

namespace SOLID.Interface.Refactor
{
    public class MultiBasico : IMultiBasico
    {
        public void Escanear()
        {
            Console.WriteLine("Escaneo tu documento");
        }

        public void Imprimir()
        {
            Console.WriteLine("Imprimo tu documento");
        }
    }
}