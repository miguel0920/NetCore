using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Facade.Api
{
    public class HotelAPI
    {
        public void BuscarHoteles(string fechaEntrada, string fechaSalida, string origen, string destino)
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine($"Hoteles encontrados");
            Console.WriteLine($"Entrada: {fechaEntrada}, salida {fechaSalida}");
            Console.WriteLine("Hotel A");
            Console.WriteLine("Hotel B");
            Console.WriteLine("--------------------------");
        }
    }
}
