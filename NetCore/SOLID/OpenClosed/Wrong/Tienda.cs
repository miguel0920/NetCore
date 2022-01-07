using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosed.Wrong
{
    public class Tienda
    {
        public Tienda(List<Wrong.Producto> productos)
        {
            _products = productos;
        }

        public void CalcularInventario()
        {
            double total = 0;
            //foreach (var item in _products)
            //{
            //    Console.WriteLine(item);
            //    total += item.Precio;
            //}

            foreach (var item in _products)
            {
                if (item.Categoria == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    item.Precio *= 0.8;
                    Console.WriteLine(item);
                    total += item.Precio;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    item.Precio *= 1.2;
                    Console.WriteLine(item);
                    total += item.Precio;
                }
            }

            Console.WriteLine($"El total en inventario es {total}");
        }

        private List<Wrong.Producto> _products;
    }
}