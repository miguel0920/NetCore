using System;

namespace SOLID.SingletonResponsibility.Wrong
{
    public class Empleado
    {
        private string _nombre;
        private string _puesto;
        private int _edad;
        private double _sueldo;

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

        // Responsabilidad que no es del empleado

        private double CalcularImpuesto()
        {
            return _sueldo * 0.35;
        }

        public void PagarImpuestos()
        {
            double imp = CalcularImpuesto();
            Console.WriteLine($"Se paga {imp} en impuestos por parte de {_nombre}");
        }
    }
}