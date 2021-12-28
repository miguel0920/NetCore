using System;

namespace NetIntermedio.Serialization
{
    [Serializable]
    public class Laptop
    {
        public Laptop()
        {
        }

        public string Marca { get => _marca; set => _marca = value; }
        public double Precio { get => _precio; set => _precio = value; }

        public Laptop(string marca, double precio)
        {
            _marca = marca;
            _precio = precio;
        }

        public void MostrarDetalle()
        {
            Console.WriteLine($"La marca de la laptop es {_marca}");
            Console.WriteLine($"El precio es {_precio}");
        }

        private string _marca;
        private double _precio;
    }
}