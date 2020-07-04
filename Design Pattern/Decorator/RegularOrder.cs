using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Design_Pattern.Decorator
{
    public class RegularOrder : OrderBase
    {
       
        public override double CalculateTotalOrderPrice()
        {
            Console.WriteLine("Calculating the price of Regular Order");
            return inventories.Sum(x => x.Price) * 0.9;
        }
    }
}
