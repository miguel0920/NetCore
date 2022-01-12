using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversion.Refactor
{
    public class Producto
    {
        public Producto(string nombre, int tipo, double costo)
        {
            Nombre = nombre;
            Tipo = tipo;
            Costo = costo;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Tipo { get => _tipo; set => _tipo = value; }
        public double Costo { get => _costo; set => _costo = value; }

        private string _nombre;
        private int _tipo; //0 alimentos, 1 Medicina, 2 Ropa
        private double _costo;

        public override string ToString()
        {
            string tipo = _tipo switch
            {
                1 => "Alimento",
                2 => "Medicina",
                3 => "Ropa",
                _ => string.Empty
            };
            return $"{_nombre}, tipo {tipo}, costo {_costo}";
        }
    }
}