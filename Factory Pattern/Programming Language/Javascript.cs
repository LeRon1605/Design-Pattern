using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    public class Javascript : IProgrammingLanguage
    {
        public string GetLanguage()
        {
            return "Javascript language";
        }
    }
}
