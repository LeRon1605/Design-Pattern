using System;

namespace Singleton_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string data in Database.getInstance().query(x => x.Contains("R")))
            {
                Console.WriteLine(data);
            }
        }
    }
}
