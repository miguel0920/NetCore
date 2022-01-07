using System;
using System.Collections.Generic;

namespace SOLID.OpenClosed
{
    public class ImplementacionOpenClosed
    {
        public static void ImplementacionOpenClosedConsole()
        {
            Console.WriteLine("Aplicar principio abierto cerrado incorrecto");
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

            Console.WriteLine("\n----------------------------\n");

            Console.WriteLine("Aplicar principio abierto cerrado correcto");
            List<Refactor.BaseInventario> productosRefactor = new()
            {
                new Refactor.InventarioAlimento(new Refactor.Producto("Papas", 1, 12.5)),
                new Refactor.InventarioMedicamento(new Refactor.Producto("Analgesico", 2, 12.5)),
                new Refactor.InventarioAlimento(new Refactor.Producto("Tomate", 1, 12.5)),
                new Refactor.InventarioMedicamento(new Refactor.Producto("Antiacido", 2, 12.5)),
                new Refactor.InventarioAlimento(new Refactor.Producto("Manzana", 1, 12.5)),
                new Refactor.InventarioMedicamento(new Refactor.Producto("Antibiotico", 2, 12.5))
            };

            Refactor.Tienda tiendaRefactor = new(productosRefactor);
            tiendaRefactor.CalcularInventario();
        }
    }
}