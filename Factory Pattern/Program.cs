using Factory_Pattern.Factory;
using System;

namespace Factory_Pattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            IProgrammingLanguageFactory structuralFactory = new StructuralLanguageFactory();
            IProgrammingLanguage structuralLangLow = structuralFactory.CreateProgrammingLanguage(ProgrammingLanguageLevel.LOW);
            IProgrammingLanguage structuralLangHigh = structuralFactory.CreateProgrammingLanguage(ProgrammingLanguageLevel.HIGH);
            Console.WriteLine(structuralLangLow.GetLanguage());
            Console.WriteLine(structuralLangHigh.GetLanguage());

            IProgrammingLanguageFactory objectOrientedFactory = new ObjectOrientedLanguageFactory();
            IProgrammingLanguage objectOrientedLangLow = objectOrientedFactory.CreateProgrammingLanguage(ProgrammingLanguageLevel.LOW);
            IProgrammingLanguage objectOrientedLangHigh = objectOrientedFactory.CreateProgrammingLanguage(ProgrammingLanguageLevel.HIGH);
            Console.WriteLine(objectOrientedLangLow.GetLanguage());
            Console.WriteLine(objectOrientedLangHigh.GetLanguage());
        }
    }
}
