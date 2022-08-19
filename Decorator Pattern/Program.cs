using Decorator_Pattern.Decorator;
using Decorator_Pattern.Milktea;
using System;

namespace Decorator_Pattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            IMilkTea milktea = new MilkTea
            {
                Price = 30000
            };
            IMilkTea bubbleMilktea = new BubbleDecorator(milktea);
            Console.WriteLine(bubbleMilktea.Cost());
            IMilkTea bubbleBlackSugarMilktea = new BlackSugar(bubbleMilktea);
            Console.WriteLine(bubbleBlackSugarMilktea.Cost());

            IMilkTea tea = new BlackSugar(new BubbleDecorator(new MilkTea
            {
                Price = 50000
            }));
            Console.WriteLine(tea.Cost());
        }
    }
}
