using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversion
{
    public class ImplementacionDependencyInversion
    {
        public static void ImplementacionDependencyInversionConsole()
        {
            Console.WriteLine($"\nInversion de dependencia incorrecta");
            Wrong.Almacen almacen = new();
            almacen.AdicionarProducto(new Wrong.Producto("Tomate", 0, 15.50));
            almacen.AdicionarProducto(new Wrong.Producto("Banana", 0, 30));
            almacen.AdicionarProducto(new Wrong.Producto("Analgesico", 1, 23.80));
            almacen.AdicionarProducto(new Wrong.Producto("Jeans", 2, 450.99));
            almacen.AdicionarProducto(new Wrong.Producto("Manzana", 0, 12.38));
            almacen.AdicionarProducto(new Wrong.Producto("Antiacido", 1, 38.50));
            almacen.AdicionarProducto(new Wrong.Producto("Blusa", 2, 200.88));

            Console.WriteLine("-------------");

            Wrong.Auditor auditor = new(almacen);
            double total = auditor.TotalesAlimentos(); 
            Console.WriteLine($"El total de alimentos es {total}");

            Console.WriteLine($"\nInversion de dependencia correcta");

            Refactor.Almacen almacenRefactor = new();
            almacenRefactor.AdicionarProducto(new Refactor.Producto("Tomate", 0, 15.50));
            almacenRefactor.AdicionarProducto(new Refactor.Producto("Banana", 0, 30));
            almacenRefactor.AdicionarProducto(new Refactor.Producto("Analgesico", 1, 23.80));
            almacenRefactor.AdicionarProducto(new Refactor.Producto("Jeans", 2, 450.99));
            almacenRefactor.AdicionarProducto(new Refactor.Producto("Manzana", 0, 12.38));
            almacenRefactor.AdicionarProducto(new Refactor.Producto("Antiacido", 1, 38.50));
            almacenRefactor.AdicionarProducto(new Refactor.Producto("Blusa", 2, 200.88));

            Console.WriteLine("-------------");

            Refactor.Auditor auditorRefactor = new(almacenRefactor);
            double totalRefactor = auditorRefactor.TotalesAlimentos();
            Console.WriteLine($"El total de alimentos es {totalRefactor}");
        }
    }
}