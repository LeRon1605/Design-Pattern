using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class Deposit : ITransactionStrategy
    {
        public double MakeTransaction(double amount, double balance)
        {
            return balance + amount - amount * 0.02;
        }
    }
}
