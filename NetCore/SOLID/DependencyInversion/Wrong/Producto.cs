namespace SOLID.DependencyInversion.Wrong
{
    public class Producto
    {
        public Producto(string nombre, int tipo, double costo)
        {
            Nombre = nombre;
            Tipo = tipo; //0 alimento, 1 medicina, 2 ropa
            Costo = costo;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Tipo { get => _tipo; set => _tipo = value; }
        public double Costo { get => _costo; set => _costo = value; }

        private string _nombre;
        private int _tipo;
        private double _costo;

        public override string ToString()
        {
            string tipo = _tipo switch
            {
                0 => "Alimento",
                1 => "Medicina",
                2 => "Ropa",
                _ => string.Empty,
            };
            return $"{_nombre}, tipo {tipo}, costo {_costo}";
        }
    }
}