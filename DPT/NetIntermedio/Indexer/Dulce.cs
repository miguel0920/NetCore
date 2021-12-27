using System;

namespace NetIntermedio.Indexer
{
    public class Dulce
    {
        private readonly string _Nombre;
        private double _Valor;
        public Dulce(string nombre, double valor)
        {
            _Nombre = nombre;
            _Valor = valor;
        }

        public double Valor { get { return _Valor; } private set { _Valor = value; } }

        public void MostrarDetalleDulce()
        {
            Console.WriteLine($"Tu dulce {_Nombre}");
            Console.WriteLine($"Costo {_Valor}");
            Console.WriteLine($"------------------");
        }
    }
}