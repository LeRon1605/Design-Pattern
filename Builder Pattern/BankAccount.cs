using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern
{
    public class BankAccount
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public bool MobileBanking { get; set; }
        public bool NewsLetter { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Email} - {Address} - {MobileBanking} - {NewsLetter}";
        }
    }
}
