using NetIntermedio.Interfaces;
using System;
using System.Threading.Tasks;

namespace NetIntermedio.Implementacion
{
    public class Suma : IOperacion
    {
        private double _result;

        public async Task Calcular(double value1, double value2)
        {
            _result = await Task.FromResult(value1 + value2);
        }

        public void Resultado()
        {
            Console.WriteLine($"El resultado de la suma es: {_result}");
        }
    }
}