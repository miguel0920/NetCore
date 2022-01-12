using System;

namespace SOLID.DependencyInversion.Wrong
{
    public class Auditor
    {
        private Almacen _almacen;

        public Auditor(Almacen almacen)
        {
            _almacen = almacen;
        }

        public double TotalesAlimentos()
        {
            double total = 0;
            foreach (Producto product in _almacen.Inventario)
            {
                if (product.Tipo == 0)
                {
                    Console.WriteLine(product);
                    total += product.Costo;
                }
            }
            return total;
        }
    }
}