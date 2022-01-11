using System;

namespace SOLID.Interface
{
    public class ImplementacionInterface
    {
        public static void ImplementacionInterfaceConsole()
        {
            Console.WriteLine("Interface incorrecta");
            Wrong.MultiAvanzado avanzado = new();
            avanzado.Escanear();
            avanzado.Faxear();
            avanzado.Imprimir();
            avanzado.Telefono();

            Console.WriteLine("--------------------");

            Wrong.Fax fax = new();
            fax.Telefono();
            fax.Faxear();
            fax.Imprimir();

            Console.WriteLine("--------------------");

            Wrong.Multisencillo multisencillo = new();
            multisencillo.Escanear();
            multisencillo.Imprimir();
            //multisencillo.Telefono(); //Lanza Excepcion

            Console.WriteLine("\n\n Interface correcta");

            Refactor.MultiAvanzado avanzado1 = new();
            avanzado1.Escanear();
            avanzado1.Faxear();
            avanzado.Imprimir();
            avanzado.Telefono();

            Console.WriteLine("*******************");

            Refactor.Fax fax1 = new();
            fax1.Faxear();
            fax1.Telefono();

            Console.WriteLine("*******************");

            Refactor.MultiBasico basico = new();
            basico.Escanear();
            basico.Imprimir();
        }
    }
}