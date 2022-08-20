using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    public class C : IProgrammingLanguage
    {
        public string GetLanguage()
        {
            return "C language";
        }
    }
}
