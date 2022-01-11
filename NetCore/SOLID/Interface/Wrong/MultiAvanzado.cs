using System;

namespace SOLID.Interface.Wrong
{
    public class MultiAvanzado : IMultifuncional
    {
        public void Escanear()
        {
            Console.WriteLine("Escaneo un documento");
        }

        public void Faxear()
        {
            Console.WriteLine("Envio Fax");
        }

        public void Imprimir()
        {
            Console.WriteLine("Imprimo tu reporte");
        }

        public void Telefono()
        {
            Console.WriteLine("Marcando al telefono");
        }
    }
}