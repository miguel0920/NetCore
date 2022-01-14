namespace SOLID.Liskov.Refactor.Example1
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