using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern
{
    public interface IAcountBuilder
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public bool MobileBanking { get; set; }
        public bool NewsLetter { get; set; }
        public IAcountBuilder WithName(string name);
        public IAcountBuilder WithEmail(string email);
        public IAcountBuilder WithAddress(string address);
        public IAcountBuilder UseMobileBanking(bool value = true);
        public IAcountBuilder UseNewsLetter(bool value = true);
        public BankAccount Build();
    }
}
