using System;

namespace SOLID.Liskov.Wrong.Example1
{
    public class Radio : Noticiero
    {
        public Radio(string mensaje) : base(mensaje)
        {
        }

        public new void Muestra()
        {
            Console.WriteLine($"Desde el radio {_mensaje}");
        }

        // Solución
        //public override void Muestra()
        //{
        //    Console.WriteLine($"Desde el radio {_mensaje}");
        //}
    }
}