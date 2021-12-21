using NetIntermedio.Implementacion;
using NetIntermedio.Interfaces;
using System;

namespace NetIntermedio.Interfaz
{
    public static class IntegracionInterfaz
    {
        public static void IntegracionInterfazConsole()
        {
            // Polimorfismo con interfaces
            int opcion = 0;
            IOperacion operacion = new Suma();
            while (opcion != 5)
            {
                Console.WriteLine("Ingrese 1-Suma, 2-Resta, 3-Multi, 4-Division, 5-Salir");
                Console.WriteLine("Que opción desea ?");
                string value = Console.ReadLine();
                opcion = Convert.ToInt32(value);

                Console.WriteLine("Ingrese el primer valor");
                value = Console.ReadLine();
                double value1 = Convert.ToDouble(value);

                Console.WriteLine("Ingrese el segundo valor");
                value = Console.ReadLine();
                double value2 = Convert.ToDouble(value);

                switch (opcion)
                {
                    case 1:
                        operacion = new Suma();
                        break;
                    case 2:
                        operacion = new Resta();
                        break;
                    case 3:
                        operacion = new Multiplicacion();
                        break;
                    case 4:
                        operacion = new Division();
                        break;
                    default:
                        break;
                }

                operacion.Calcular(value1, value2);
                operacion.Resultado();
            }
        }
    }
}