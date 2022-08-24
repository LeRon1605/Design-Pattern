using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Pattern.People
{
    public class SouthAmerica: IAmerican
    {
        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"South American receive message: '{message}'");
        }
    }
}
