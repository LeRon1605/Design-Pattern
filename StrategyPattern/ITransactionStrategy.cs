using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public interface ITransactionStrategy
    {
        double MakeTransaction(double amount, double balance);
    }
}
