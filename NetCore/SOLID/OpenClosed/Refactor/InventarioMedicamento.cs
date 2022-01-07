using System;

namespace SOLID.OpenClosed.Refactor
{
    public class InventarioMedicamento : BaseInventario
    {
        public InventarioMedicamento(Producto producto) : base(producto) { }

        public override double CalcularProducto()
        {
            Producto.Precio *= 1.5;
            return Producto.Precio;
        }
    }
}