using System;

namespace SOLID.Interface.Wrong
{
    public class Fax : IMultifuncional
    {
        public void Escanear()
        {
            Console.WriteLine("No tengo este servicio");
        }

        public void Faxear()
        {
            Console.WriteLine("Envio un fax");
        }

        public void Imprimir()
        {
            Console.WriteLine("No tengo este servicio");
        }

        public void Telefono()
        {
            Console.WriteLine("Marcando a un telefono");
        }
    }
}