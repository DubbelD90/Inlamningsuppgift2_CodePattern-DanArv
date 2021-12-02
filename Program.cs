using Design_Patterns_Assignment;

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var decoratorRun = new DecoratorRun();
            var strategyRun = new StrategyRun();

            decoratorRun.Run();
            //Repository.Run();
            //strategyRun.Run();
            //Observer.Run();
        }     
    }
}
