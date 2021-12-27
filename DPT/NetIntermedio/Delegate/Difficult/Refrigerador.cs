using System;

namespace NetIntermedio.Delegate.Difficult
{
    public class Refrigerador
    {
        public delegate void ReservasBajas(int kilos);
        public delegate void Descongelado(int grados);

        public Refrigerador(int kilos, int grados)
        {
            _kilosAlimentos = kilos;
            _grados = grados;
        }

        public int Kilos { get => _kilosAlimentos; set => _kilosAlimentos = value; }
        public int Grados { get => _grados; set => _grados = value; }

        public void AdicionarReserva(ReservasBajas metodo) => reservas += metodo;
        public void EliminarReserva(ReservasBajas metodo) => reservas -= metodo;
        public void AdicionarDescongelado(Descongelado metodo) => descongelado += metodo;

        public void Trabajar(int consumo)
        {
            // Actualizamos los kilos del refrigerio
            _kilosAlimentos -= consumo;

            _grados += 1;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{_kilosAlimentos} kilos, {_grados} grados");

            if (_kilosAlimentos < 10)
            {
                reservas(_kilosAlimentos);
            }

            if (_grados > 0)
            {
                descongelado(_grados);
            }
        }

        private int _kilosAlimentos = 0;
        private int _grados = 0;

        private ReservasBajas reservas;
        private Descongelado descongelado;

    }
}