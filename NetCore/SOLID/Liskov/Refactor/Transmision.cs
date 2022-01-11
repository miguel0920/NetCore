namespace SOLID.Liskov.Refactor
{
    public abstract class Transmision
    {
        protected string _mensaje;

        public Transmision(string mensaje)
        {
            _mensaje = mensaje;
        }

        public abstract void Muestra();
    }
}