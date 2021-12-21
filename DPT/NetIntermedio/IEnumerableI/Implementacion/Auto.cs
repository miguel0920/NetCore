using NetIntermedio.IEnumerableI.Interfaz;
using System;

namespace NetIntermedio.IEnumerableI.Implementacion
{
    public class Auto : IAutomovil
    {
        private double tenencia;
        private readonly double _costo;
        private readonly string _modelo;
        public Auto(string modelo, double costo)
        {
            _costo = costo;
            _modelo = modelo;
        }
        public void CalcularTenencia(double impuesto)
        {
            tenencia = 5000.0 + _costo * impuesto;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Tu automovil {_modelo}");
            Console.WriteLine($"Costo {_costo} con una tenencia de: {tenencia}");
            Console.WriteLine($"Total: {_costo + tenencia}");
            Console.WriteLine($"-----------------------");
        }
    }
}