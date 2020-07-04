using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern.Decorator
{
    public abstract class OrderBase
    {

        
        protected List<Inventory> inventories = new List<Inventory>
            {
                new Inventory{ProductName="IPhone", Price=1000, Count=90},
                new Inventory{ProductName="IPad", Price=800, Count=50},
                new Inventory{ProductName="chanrger", Price=80, Count=25}
            };


        public abstract double CalculateTotalOrderPrice();
       // public abstract int ItemsAvailable();

    }
}
