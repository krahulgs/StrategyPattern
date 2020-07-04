using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern.Decorator
{
    public class PremiumOrder:OrderDecorator
    {
        public PremiumOrder(OrderBase order) : base(order)
        {

        }
        public override double CalculateTotalOrderPrice()
        {
            Console.WriteLine($"Calculating the total Price in the {nameof(PremiumOrder)}");
            var PreOrderPrice = base.CalculateTotalOrderPrice();

            Console.WriteLine("Adding Addition discount for Premium order");
            return PreOrderPrice*0.9;
        }
    }
}
