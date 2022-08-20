using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern.Factory
{
    public class StructuralLanguageFactory : IProgrammingLanguageFactory
    {
        public IProgrammingLanguage CreateProgrammingLanguage(ProgrammingLanguageLevel level)
        {
            switch (level)
            {
                case ProgrammingLanguageLevel.LOW:
                    return new C();
                case ProgrammingLanguageLevel.HIGH:
                    return new Javascript();
                default:
                    return null;
            }
        }
    }
}
