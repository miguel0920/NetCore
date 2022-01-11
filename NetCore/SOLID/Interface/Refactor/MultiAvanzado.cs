using System;

namespace SOLID.Interface.Refactor
{
    public class MultiAvanzado : IMultiCompleto
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