namespace SOLID.OpenClosed.Refactor
{
    public abstract class BaseInventario
    {
        public Producto Producto { get => _producto; set => _producto = value; }
        public BaseInventario(Producto producto)
        {
            _producto = producto;
        }

        public override string ToString()
        {
            return _producto.ToString();
        }

        public abstract double CalcularProducto();

        protected Producto _producto;
    }
}