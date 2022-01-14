using SOLID.OpenClosed.Wrong.Example2;
using System;
using System.Collections.Generic;

namespace SOLID.OpenClosed
{
    public class ImplementacionOpenClosed
    {
        public static void ImplementacionOpenClosedConsole()
        {
            Console.WriteLine("Aplicar principio abierto cerrado incorrecto ejemplo 1");
            List<Wrong.Example1.Producto> productos = new()
            {
                new Wrong.Example1.Producto("Papas", 1, 12.5),
                new Wrong.Example1.Producto("Analgesico", 2, 12.5),
                new Wrong.Example1.Producto("Tomate", 1, 12.5),
                new Wrong.Example1.Producto("Antiacido", 2, 12.5),
                new Wrong.Example1.Producto("Manzana", 1, 12.5),
                new Wrong.Example1.Producto("Antibiotico", 2, 12.5)
            };

            Wrong.Example1.Tienda tienda = new(productos);
            tienda.CalcularInventario();

            Console.WriteLine("\n----------------------------\n");

            Console.WriteLine("Aplicar principio abierto cerrado correcto ejemplo 1");
            List<Refactor.Example1.BaseInventario> productosRefactor = new()
            {
                new Refactor.Example1.InventarioAlimento(new Refactor.Example1.Producto("Papas", 1, 12.5)),
                new Refactor.Example1.InventarioMedicamento(new Refactor.Example1.Producto("Analgesico", 2, 12.5)),
                new Refactor.Example1.InventarioAlimento(new Refactor.Example1.Producto("Tomate", 1, 12.5)),
                new Refactor.Example1.InventarioMedicamento(new Refactor.Example1.Producto("Antiacido", 2, 12.5)),
                new Refactor.Example1.InventarioAlimento(new Refactor.Example1.Producto("Manzana", 1, 12.5)),
                new Refactor.Example1.InventarioMedicamento(new Refactor.Example1.Producto("Antibiotico", 2, 12.5))
            };

            Refactor.Example1.Tienda tiendaRefactor = new(productosRefactor);
            tiendaRefactor.CalcularInventario();

            Console.WriteLine("\nAplicar principio abierto cerrado incorrecto ejemplo 2");

            Wrong.Example2.DiscountManager discountManager = new();
            double value = 1000;
            Console.WriteLine($"Descuento BlackFriday valor {value}, descuento {discountManager.Apply(value, new Wrong.Example2.BlackFriday())}");


            Console.WriteLine("\nAplicar principio abierto cerrado correcto ejemplo 2");

            Refactor.Example2.DiscountManager discountManagerRefactor = new();
            Console.WriteLine($"Descuento Descount valor {value}, descuento {discountManagerRefactor.Apply(value, new Refactor.Example2.Discount())}");
        }
    }
}