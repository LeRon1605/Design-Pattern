using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class Card
    {
        public string ID { get; set; }
        public double Balance { get; set; }
        public ITransactionStrategy TransactionStrategy { get; set; }
        public void MakeTransaction(double Amount)
        {
            Balance = TransactionStrategy.MakeTransaction(Amount, Balance);
        }
        public override string ToString()
        {
            return $"{ID} - Balance: {Balance} - Transaction: {TransactionStrategy.GetType().Name}";
        }
    }
}
