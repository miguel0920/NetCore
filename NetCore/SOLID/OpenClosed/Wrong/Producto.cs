using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosed.Wrong
{
    public class Producto
    {
        public Producto(string nombre, int categoria, double precio)
        {
            _nombre = nombre;
            _categoria = categoria;
            _precio = precio;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Categoria { get => _categoria; set => _categoria = value; }
        public double Precio { get => _precio; set => _precio = value; }

        public override string ToString()
        {
            return $"El producto {_nombre} cuesta {_precio}";
        }

        private string _nombre;
        private int _categoria;
        private double _precio;
    }
}