namespace SOLID.OpenClosed.Refactor
{
    public class InventarioAlimento : BaseInventario
    {
        public InventarioAlimento(Producto producto) : base(producto) { }
        public override double CalcularProducto()
        {
            Producto.Precio *= 0.8;
            return Producto.Precio;
        }
    }
}