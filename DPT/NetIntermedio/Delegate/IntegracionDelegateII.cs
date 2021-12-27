using NetIntermedio.Delegate.Difficult;
using System;

namespace NetIntermedio.Delegate
{
    public class IntegracionDelegateII
    {
        public static void IntegracionDelegateIIConsole()
        {
            Refrigerador refrigerador = new(100, -40);
            Random random = new();

            //Adicionamos los multi-handlers
            refrigerador.AdicionarReserva(new Refrigerador.ReservasBajas(InformeKilos));
            refrigerador.AdicionarReserva(new Refrigerador.ReservasBajas(Tienda.Mensaje));
            refrigerador.AdicionarDescongelado(new Refrigerador.Descongelado(InformeGrados));

            // Trabajo de la refrigeradora
            while (refrigerador.Kilos > 0)
            {
                refrigerador.Trabajar(random.Next(1, 5));
            }

            //Eliminar handler
            refrigerador.EliminarReserva(Tienda.Mensaje);

            refrigerador.Kilos = 40;
            refrigerador.Grados = -30;


            while (refrigerador.Kilos > 0)
            {
                refrigerador.Trabajar(random.Next(1, 5));
            }
        }

        public static void InformeKilos(int kilos)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Reserva baja de alimentos, estoy a nivel de {nameof(IntegracionDelegateII)}");
            Console.WriteLine($"Quedan {kilos} kilos");
        }

        public static void InformeGrados(int grados)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Se descongela el refrigerador, estoy a nivel de {nameof(IntegracionDelegateII)}");
            Console.WriteLine($"Quedan {grados} grados");
        }
    }
}