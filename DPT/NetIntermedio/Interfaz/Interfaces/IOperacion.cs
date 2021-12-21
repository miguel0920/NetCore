using System.Threading.Tasks;

namespace NetIntermedio.Interfaces
{
    public interface IOperacion
    {
        Task Calcular(double value1, double value2);
        void Resultado();
    }
}