namespace SOLID.OpenClosed.Refactor.Example2
{
    public class Discount : IDiscount
    {
        public double Apply(double price)
        {
            return price * 0.1;
        }
    }
}