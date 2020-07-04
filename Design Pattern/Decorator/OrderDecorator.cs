using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Design_Pattern.Decorator
{
   public class OrderDecorator : OrderBase
    {
        protected OrderBase order;

        public OrderDecorator(OrderBase order)
        {
            this.order = order;
        }
        public override double CalculateTotalOrderPrice()
        {
            Console.WriteLine("Calculating the total Proce of Orderdecorator");
            return order.CalculateTotalOrderPrice();
        }
    }
}
