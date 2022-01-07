using System;
using System.Collections.Generic;

namespace SOLID.OpenClosed.Wrong
{
    public class Tienda
    {
        public Tienda(List<Producto> productos)
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

        private List<Producto> _products;
    }
}