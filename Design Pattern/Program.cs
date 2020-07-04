using Design_Pattern.Decorator;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var Rahul = new Shopper("Rahul", 10000);



            var RegularOrder = new RegularOrder();
            Console.WriteLine(RegularOrder.CalculateTotalOrderPrice());
           

            var preOrder = new PreOrder();
            Console.WriteLine(preOrder.CalculateTotalOrderPrice());

            var premiumPreorder = new PremiumOrder(preOrder);
            Console.WriteLine(premiumPreorder.CalculateTotalOrderPrice());

            Console.ReadLine();
        }
    }
}
