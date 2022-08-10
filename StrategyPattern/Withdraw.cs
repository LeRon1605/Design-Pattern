using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class Withdraw : ITransactionStrategy
    {
        public double MakeTransaction(double amount, double balance)
        {
            if (amount + amount * 0.05 <= balance)
            {
                return balance - (amount + amount * 0.05);
            }
            return balance;
        }
    }
}
