using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Pattern.People
{
    public class NorthAmerican : IAmerican
    {
        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"North American receive message: '{message}'");
        }
    }
}
