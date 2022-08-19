using Decorator_Pattern.Milktea;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Pattern.Decorator
{
    public class BubbleDecorator : MilkTeaDecorator
    {
        public BubbleDecorator(IMilkTea milkTea) : base(milkTea)
        {
        }

        public override double Cost()
        {
            return 5000 + base.Cost();
        }
    }
}
