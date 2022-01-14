using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosed.Refactor.Example2
{
    public class DiscountManager
    {
        public Double Apply(double price, IDiscount discount)
        {
            return discount.Apply(price);
        }
    }
}