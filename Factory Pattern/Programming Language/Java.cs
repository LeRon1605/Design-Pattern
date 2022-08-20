using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    public class Java : IProgrammingLanguage
    {
        public string GetLanguage()
        {
            return "Java language";
        }
    }
}
