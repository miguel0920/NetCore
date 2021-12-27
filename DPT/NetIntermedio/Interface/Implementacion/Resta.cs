using NetIntermedio.Interfaces;
using System;
using System.Threading.Tasks;

namespace NetIntermedio.Implementacion
{
    public class Resta : IOperacion
    {
        private double _result;
        public async Task Calcular(double value1, double value2)
        {
            _result = await Task.FromResult(value1 - value2);
        }

        public void Resultado()
        {
            Console.WriteLine($"El resultado de la resta es: {_result}");
        }
    }
}