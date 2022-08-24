using System;
using System.Collections.Generic;
using System.Text;
using Adapter_Pattern.People;

namespace Adapter_Pattern.Translator
{
    public class AmericanTranslator : ITranslator
    {
        public IAmerican American { get; set; }
        public string SendMessage(string message)
        {
            Console.WriteLine("American translator send message from vietnam");
            string englishMessage = Translate(message);
            American.ReceiveMessage(englishMessage);
            return englishMessage;
        }
        public string Translate(string message)
        {
            // Translate to american
            return $"Hello from VietNam: {message}";
        }
    }
}
