using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Pattern.Milktea
{
    public class MilkTea : IMilkTea
    {
        public double Price { get; set; }
        public double Cost()
        {
            return Price;
        }
    }
}
