using System;
using System.Collections.Generic;

namespace SOLID.OpenClosed.Refactor.Example1
{
    public class Tienda
    {
        public Tienda(List<BaseInventario> productos)
        {
            _productos = productos;
        }

        public void CalcularInventario()
        {
            double total = 0;
            foreach (var item in _productos)
            {
                item.CalcularProducto();
                Console.WriteLine(item);
                total += item.Producto.Precio;
            }

            Console.WriteLine($"El total en inventario es {total}");
        }

        private List<BaseInventario> _productos;
    }
}