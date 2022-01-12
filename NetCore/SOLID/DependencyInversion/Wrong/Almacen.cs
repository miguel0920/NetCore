using System;
using System.Collections.Generic;

namespace SOLID.DependencyInversion.Wrong
{
    public class Almacen
    {
        public Almacen()
        {
            inventario = new List<Producto>();
        }

        // Nos vemos forzados a crear la propiedad para que se pueda contar el inventario
        // Al ser una propiedad de tipo List forzamos a Auditor a trabajar con List
        public List<Producto> Inventario { get => inventario; set => inventario = value; }

        public void AdicionarProducto(Producto product)
        {
            inventario.Add(product);
            Console.WriteLine($"Adicionamos {product.Nombre}");
        }

        private List<Producto> inventario;
    }
}