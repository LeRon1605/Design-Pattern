using System;
using System.Collections.Generic;
using System.Text;
using Adapter_Pattern.People;

namespace Adapter_Pattern.Translator
{
    public interface ITranslator : IVietNamese
    {
        string Translate(string message);
    }
}
