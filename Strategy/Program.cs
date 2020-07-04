using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var Context = new Context();
            Console.WriteLine("Client: Strategy is set to normal sorting.");
            Context.SetStrategy(new ConcreteStrategyA());
            Context.DoSomeBusinessLogic();

            Console.WriteLine();

            Console.WriteLine("Client: Strategy is set to reverse sorting.");
            Context.SetStrategy(new ConcreteStrategyB());
            Context.DoSomeBusinessLogic();
        }
    }
}
