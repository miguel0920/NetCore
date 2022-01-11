using System;

namespace SOLID.Liskov.Refactor
{
    public class Radio : Transmision
    {
        public Radio(string mensaje) : base(mensaje)
        {
        }

        public override void Muestra()
        {
            Console.WriteLine($"Desde el radio {_mensaje}");
        }
    }
}