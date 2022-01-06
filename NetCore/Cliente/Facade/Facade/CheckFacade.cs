using Cliente.Facade.Api;

namespace Cliente.Facade.Facade
{
    public class CheckFacade
    {
        private readonly AvionAPI avionAPI;
        private readonly HotelAPI hotelAPI;
        public CheckFacade()
        {
            avionAPI = new AvionAPI();
            hotelAPI = new HotelAPI();
        }

        public void Buscar(string fechaId, string fechaVuelta, string origen, string destino)
        {
            avionAPI.BuscarVuelos(fechaId, fechaVuelta, origen, destino);
            hotelAPI.BuscarHoteles(fechaId, fechaVuelta, origen, destino);
        }
    }
}
