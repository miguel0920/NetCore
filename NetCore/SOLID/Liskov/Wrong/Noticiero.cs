using System;

namespace SOLID.Liskov.Wrong
{
    public class Noticiero
    {
        protected string _mensaje;

        public Noticiero(string mensaje)
        {
            _mensaje = mensaje;
        }

        public void Muestra()
        {
            Console.WriteLine($"Desde el noticiero {_mensaje}");
        }

        //Solución
        //public virtual void Muestra()
        //{
        //    Console.WriteLine($"Desde el noticiero {_mensaje}");
        //}
    }
}