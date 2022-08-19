using Decorator_Pattern.Milktea;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Pattern.Decorator
{
    public class BlackSugar : MilkTeaDecorator
    {
        public BlackSugar(IMilkTea milkTea) : base(milkTea)
        {
        }

        public override double Cost()
        {
            return 3500 + base.Cost();
        }
    }
}
