using System;

namespace NetIntermedio.Delegate.Simple
{
    public class Radio
    {
        public static void MensajeRadio(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("---------------");
            Console.WriteLine($"El radio notifica el siguiente mensaje {mensaje}");
        }
    }
}