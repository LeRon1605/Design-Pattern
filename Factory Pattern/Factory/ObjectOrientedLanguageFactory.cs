using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern.Factory
{
    public class ObjectOrientedLanguageFactory : IProgrammingLanguageFactory
    {
        public IProgrammingLanguage CreateProgrammingLanguage(ProgrammingLanguageLevel level)
        {
            switch (level)
            {
                case ProgrammingLanguageLevel.LOW:
                    return new CPlusPlus();
                case ProgrammingLanguageLevel.HIGH:
                    return new Java();
                default:
                    return null;
            }
        }
    }
}
