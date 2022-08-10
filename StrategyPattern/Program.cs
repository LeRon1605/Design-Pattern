using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card = new Card
            {
                ID = "Card 1",
                Balance = 50000,
                TransactionStrategy = new Withdraw()
            };
            Console.WriteLine(card.ToString());
            card.MakeTransaction(30000);
            Console.WriteLine(card.ToString());
            card.TransactionStrategy = new Deposit();
            card.MakeTransaction(30000);
            Console.WriteLine(card.ToString());
        }
    }
}
