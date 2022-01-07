using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosed
{
    public class ImplementacionOpenClosed
    {
        public static void ImplementacionOpenClosedConsole()
        {
            List<Wrong.Producto> productos = new()
            {
                new Wrong.Producto("Papas", 1, 12.5),
                new Wrong.Producto("Analgesico", 2, 12.5),
                new Wrong.Producto("Tomate", 1, 12.5),
                new Wrong.Producto("Antiacido", 2, 12.5),
                new Wrong.Producto("Manzana", 1, 12.5),
                new Wrong.Producto("Antibiotico", 2, 12.5)
            };

            Wrong.Tienda tienda = new(productos);
            tienda.CalcularInventario();
        }
    }
}