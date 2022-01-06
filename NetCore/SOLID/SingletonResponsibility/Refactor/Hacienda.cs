using System;

namespace SOLID.SingletonResponsibility.Refactor
{
    public class Hacienda
    {
        private static double CalcularImpuesto(Empleado empleado)
        {
            return empleado.Sueldo * 0.35;
        }

        public static void PagarImpuestos(Empleado empleado)
        {
            double imp = CalcularImpuesto(empleado);
            Console.WriteLine($"Se paga {imp} en impuestos por parte de {empleado.Nombre}");
        }
    }
}