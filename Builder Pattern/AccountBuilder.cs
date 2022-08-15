using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern
{
    public class AccountBuilder : IAcountBuilder
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public bool MobileBanking { get; set; }
        public bool NewsLetter { get; set; }

        public IAcountBuilder UseMobileBanking(bool value)
        {
            MobileBanking = value;
            return this;
        }

        public IAcountBuilder UseNewsLetter(bool value)
        {
            NewsLetter = value;
            return this;
        }

        public IAcountBuilder WithAddress(string address)
        {
            Address = address;
            return this;
        }

        public IAcountBuilder WithEmail(string email)
        {
            Email = email;
            return this;
        }

        public IAcountBuilder WithName(string name)
        {
            Name = name;
            return this;
        }

        public BankAccount Build()
        {
            return new BankAccount
            {
                Name = this.Name,
                Address = this.Address,
                Email = this.Email,
                MobileBanking = this.MobileBanking,
                NewsLetter = this.NewsLetter
            };
        }
    }
}
