using System;

namespace Cliente.Facade.Api
{
    public class AvionAPI
    {
        public void BuscarVuelos(string fechaIda, string fechaVuelta, string origen, string destino)
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine($"Vuelos encontrados para {destino} desde {origen}");
            Console.WriteLine($"Fecha ida {fechaIda} fecha vuelta {fechaVuelta}");
            Console.WriteLine("--------------------------");
        }
    }
}
