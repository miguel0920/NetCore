namespace SOLID.SingletonResponsibility.Refactor.Example1
{
    public class Empleado
    {
        private string _nombre;
        private string _puesto;
        private int _edad;
        private double _sueldo;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public double Sueldo { get => _sueldo; set => _sueldo = value; }

        public Empleado(string nombre, string puesto, int edad, double sueldo)
        {
            _nombre = nombre;
            _puesto = puesto;
            _edad = edad;
            _sueldo = sueldo;
        }

        public override string ToString()
        {
            return $"{_nombre}, {_puesto}, {_edad}, {_sueldo}";
        }

        // Aqui puede ir otros metodos propios de empleado
        // AsignarHorario()
        // ProyectoActual()
    }
}