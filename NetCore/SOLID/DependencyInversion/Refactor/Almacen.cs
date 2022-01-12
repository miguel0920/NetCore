using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversion.Refactor
{
    public class Almacen : IAuditable
    {
        private List<Producto> inventario;

        public Almacen()
        {
            inventario = new List<Producto>();
        }

        public void AdicionarProducto(Producto producto)
        {
            inventario.Add(producto);
            Console.WriteLine($"Adicionamos {producto.Nombre}");
        }

        // Implementación de la interfaz, hacemos la busqueda flexible
        public IEnumerable<Producto> ObtenerProductos(int tipo)
        { 
            List<Producto> encontrados  = new List<Producto>();

            foreach (Producto producto in inventario)
            {
                if (producto.Tipo == tipo)
                    encontrados.Add(producto);
            }
            return encontrados;
        }
    }
}