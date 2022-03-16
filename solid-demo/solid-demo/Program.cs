using L;
using O;
using System;

namespace solid_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Runner");

            switch (Console.ReadLine().ToString().ToUpper())
            {
                case "L": LiskovRunner.Run();
                    break;
                case "O": RunO();
                    break;
                default:
                    break;
            }
            
            
        }

        private static void RunO()
        {
            var context = new Context();

            Console.WriteLine("Client: Strategy is set to normal sorting.");
            context.SetStrategy(new ConcreteStrategyA());
            context.DoSomeBusinessLogic();

            Console.WriteLine();

            Console.WriteLine("Client: Strategy is set to reverse sorting.");
            context.SetStrategy(new ConcreteStrategyB());
            context.DoSomeBusinessLogic();
        }
    }
}
