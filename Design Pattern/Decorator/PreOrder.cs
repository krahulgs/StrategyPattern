using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace Design_Pattern.Decorator
{
    public class PreOrder : OrderBase
    {
        
        public override double CalculateTotalOrderPrice()
        {
            Console.WriteLine("Calculating the price of Pre Order");
            return inventories.Sum(x => x.Price) * 0.5;
        }

      
    }
}
