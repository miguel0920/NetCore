using System;

namespace NetIntermedio.Delegate.Simple
{
    public class Pastel
    {
        public static void MensajePastel(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("---------------");
            Console.WriteLine($"El pastel se hace con {mensaje}");
        }
    }
}