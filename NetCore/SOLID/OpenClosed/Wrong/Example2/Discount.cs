namespace SOLID.OpenClosed.Wrong.Example2
{
    public class Discount
    {
        public double Apply(double price)
        {
            return price * 0.1;
        }
    }
}