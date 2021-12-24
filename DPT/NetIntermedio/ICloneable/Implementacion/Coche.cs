using NetIntermedio.ICloneable.Interfaz;
using System;

namespace NetIntermedio.ICloneable.Implementacion
{
    public class Coche : ICarro, System.ICloneable
    {
        public Coche(string modelo, double costo)
        {
            _modelo = modelo;
            Costo = costo;
        }

        public double Costo { get => _costo; set => _costo = value; }
        public double Tenencia { get; set; }

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

        public object Clone()
        {
            Coche coche = new(_modelo, Costo);
            coche.Tenencia = tenencia;
            return coche;
        }

        private double tenencia;
        private double _costo;
        private readonly string _modelo;
    }
}
