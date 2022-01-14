using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosed.Wrong.Example2
{
    public class GoldDiscount
    {
        public double Apply(double price)
        {
            return price * 0.4;
        }
    }
}