using System;

namespace SOLID.Liskov.Refactor
{
    public class Noticiero : Transmision
    {
        public Noticiero(string mensaje) : base(mensaje)
        {
        }

        public override void Muestra()
        {
            Console.WriteLine($"Desde el noticiero {_mensaje}");
        }
    }
}