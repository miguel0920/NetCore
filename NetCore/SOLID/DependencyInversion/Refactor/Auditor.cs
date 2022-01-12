using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversion.Refactor
{
    public class Auditor
    {
        private IAuditable _almacen;

        public Auditor(IAuditable almacen)
        {
            _almacen = almacen;
        }

        public double TotalesAlimentos()
        {
            double total = 0;
            IEnumerable<Producto> listado = _almacen.ObtenerProductos(0);
            foreach (Producto producto in listado)
            {
                Console.WriteLine(producto);
                total += producto.Costo;
            }
            return total;
        }
    }
}