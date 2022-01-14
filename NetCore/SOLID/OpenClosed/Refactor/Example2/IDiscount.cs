using System;
namespace SOLID.OpenClosed.Refactor.Example2
{
    public interface IDiscount
    {
        Double Apply(Double value);
    }
}