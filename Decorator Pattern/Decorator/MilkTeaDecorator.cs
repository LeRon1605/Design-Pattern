using Decorator_Pattern.Milktea;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Pattern.Decorator
{
    public abstract class MilkTeaDecorator: IMilkTea
    {
        private IMilkTea _milkTea;
        public MilkTeaDecorator(IMilkTea milkTea)
        {
            _milkTea = milkTea;
        }

        public virtual double Cost()
        {
            return _milkTea.Cost();
        }
    }
}
