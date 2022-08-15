using System;

namespace Builder_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new AccountBuilder().WithName("Ron")
                                                      .WithEmail("ronle9519@gmail.com")
                                                      .WithAddress("Hue")
                                                      .UseMobileBanking()
                                                      .UseNewsLetter(false)
                                                      .Build();
            Console.WriteLine(account.ToString());
        }
    }
}
