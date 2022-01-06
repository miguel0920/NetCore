using System;

namespace SOLID.SingletonResponsibility
{
    public class ImplementacionSingleton
    {
        public static void ImplementacionSingletonConsole()
        {
            Wrong.Empleado empleadoWrong = new("Miguel", "Software Developer", 24, 1500.000);
            empleadoWrong.PagarImpuestos();

            Refactor.Empleado empleadoRefactor = new("Pablo", "Software Developer II", 24, 2500.000);
            Console.WriteLine(empleadoRefactor);
            Refactor.Hacienda.PagarImpuestos(empleadoRefactor);
        }
    }
}