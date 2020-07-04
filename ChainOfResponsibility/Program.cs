using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Reflection.Metadata.Ecma335;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var monkey = new MonkeyHandler();
            var Squirrel=new SquirrelHandler();
            var dog = new DogHandler();

            monkey.SetNext(Squirrel).SetNext(dog);

            Console.WriteLine("Chain: Monkey>Squirrel>Dog \n");

            Client.ClientCode(monkey);
            Console.WriteLine();

            Console.WriteLine("Sub Chain: Squirrel> Dog \n");
            Client.ClientCode(Squirrel);

            Console.ReadLine();
        }
    }

    internal class DogHandler:AbstractHandler
    {
        public override object Handle(object Request)
        {
            if (Request.ToString() == "MeatBall")
            {
                return $"Dog : I will eat the {Request.ToString()} \n";
            }
            else
            {
                return base.Handle(Request);
            }

        }
    }

    internal class SquirrelHandler:AbstractHandler
    {
        public override object Handle(object Request)
        {
            if (Request.ToString() == "Nut")
            {
                return $"Squirrel : I will eat the {Request.ToString()} \n";
            }
            else
            {
                return base.Handle(Request);
            }

        }
    }

    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        Object Handle(Object request);
    }

    public class AbstractHandler : IHandler
    {
        public IHandler NextHandler;

        public virtual object Handle(object request)
        {
            if (this.NextHandler != null)
            {
                return this.NextHandler.Handle(request);
            }
            else
            {
                return null;
            }
        }

        public IHandler SetNext(IHandler handler)
        {
            this.NextHandler = handler;
            return handler;
        }
    }


    internal class Client
    {
        public static void ClientCode(AbstractHandler handler)
        {
            foreach (var food in new List<string> { "Nut", "Banana", "Cup of coffee" })
            {
                Console.WriteLine($"Client: Who wants a {food}?");

                var result = handler.Handle(food);

                if (result != null)
                {
                    Console.Write($"   {result}");
                }
                else
                {
                    Console.WriteLine($"   {food} was left untouched.");
                }
            }
        }
    }
    public class MonkeyHandler : AbstractHandler
    {
        public override object Handle(object Request)
        {
            if (Request.ToString() == "Banana")
            {
                return $"Monkey : I will eat the {Request.ToString()} \n";
            }
            else
            {
                return base.Handle(Request);
            }
                
        }
    }
}
