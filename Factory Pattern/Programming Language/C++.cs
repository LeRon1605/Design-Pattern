using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    public class CPlusPlus : IProgrammingLanguage
    {
        public string GetLanguage()
        {
            return "C++ Language";
        }
    }
}
