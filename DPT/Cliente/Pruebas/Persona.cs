using System;

namespace Cliente.Pruebas
{
    class Persona
    {
        public Persona(string nombre, double edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        protected string nombre;
        protected double edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public double Edad
        {
            get
            {
                return edad;
            }
            set
            {
                if (value >= 18)
                {
                    edad = value;
                }
                else
                {
                    edad = -1;
                }
            }
        }

        public void Mostrar()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
        }
    }
}
