using NetIntermedio.Delegate.Difficult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetIntermedio.Delegate
{
    public class IntegracionDelegateII
    {
        public static void IntegracionDelegateIIConsole()
        {
            Refrigerador refrigerador = new(100, -40);
            Random random = new();

            //Adicionamos los handlers
            refrigerador.AdicionarReserva(new Refrigerador.ReservasBajas(InformeKilos));
            refrigerador.AdicionarDescongelado(new Refrigerador.Descongelado(InformeGrados));

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