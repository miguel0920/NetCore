namespace Singleton.SingletonII.Model
{
    public class TipoDocumento
    {
        public TipoDocumento(string nombre, string abreviatura)
        {
            _nombre = nombre;
            _abreviatura = abreviatura;
        }

        public override string ToString()
        {
            return $"Tipo de documento: {_nombre}, abreviatura:{_abreviatura}";
        }

        private readonly string _nombre;
        private readonly string _abreviatura;
    }
}