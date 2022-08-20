using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern.Factory
{
    public interface IProgrammingLanguageFactory
    {
        IProgrammingLanguage CreateProgrammingLanguage(ProgrammingLanguageLevel level);
    }
}
