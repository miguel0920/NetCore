﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosed.Refactor.Example2
{
    public class BlackFriday : IDiscount
    {
        public double Apply(double price)
        {
            return price * 0.5;
        }
    }
}