using System;
using Adapter_Pattern.People;
using Adapter_Pattern.Translator;

namespace Adapter_Pattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IVietNamese vietname = new AmericanTranslator
            {
                American = new NorthAmerican()
            };
            vietname.SendMessage("Xin chào");
            vietname = new AmericanTranslator
            {
                American = new SouthAmerica()
            };
            vietname.SendMessage("Xin chào");
        }
    }
}
