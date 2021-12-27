using System;

namespace NetIntermedio.Delegate.Difficult
{
    public class Tienda
    {
        public static void Mensaje(int kilos)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Vamos a enviar sus viveres, estoy en la tienda");
            Console.WriteLine($"Seran {kilos} kilos");
        }
    }
}