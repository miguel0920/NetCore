using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetIntermedio.Files
{
    public class Phone
    {
        private string _modelo;
        private double _precio;

        public double Precio { get => _precio; set => _precio = value; }
        public string Modelo { get => _modelo; set => _modelo = value; }

        public Phone(string modelo, double precio)
        {
            _modelo = modelo;
            _precio = precio;
        }

        public void PhoneDetail()
        {
            Console.WriteLine($"Modelo del telefono: {_modelo}");
            Console.WriteLine($"Precio del telefono: {_precio}");
            Console.WriteLine("-------------");
        }
    }
}