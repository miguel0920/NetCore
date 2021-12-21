using NetIntermedio.Interfaces;
using System;
using System.Threading.Tasks;

namespace NetIntermedio.Implementacion
{
    public class Division : IOperacion
    {
        private double _result;
        public async Task Calcular(double value1, double value2)
        {
            if (value1 <= 0)
                value1 = 1;
            _result = await Task.FromResult(value1 / value2);
        }

        public void Resultado()
        {
            Console.WriteLine($"El resultado de la división es: {_result}");
        }
    }
}