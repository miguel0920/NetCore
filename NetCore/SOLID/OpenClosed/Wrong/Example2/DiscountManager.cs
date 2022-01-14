using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosed.Wrong.Example2
{
    public class DiscountManager
    {
        public Double Apply(double price, Discount discount)
        {
            return discount.Apply(price);
        }

        public Double Apply(double price, GoldDiscount discount)
        {
            return discount.Apply(price);
        }

        public Double Apply(double price, BlackFriday discount)
        {
            return discount.Apply(price);
        }
    }
}