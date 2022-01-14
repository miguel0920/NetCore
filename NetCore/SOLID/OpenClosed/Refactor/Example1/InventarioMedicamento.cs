namespace SOLID.OpenClosed.Refactor.Example1
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