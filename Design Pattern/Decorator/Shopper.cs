using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace Design_Pattern.Decorator
{
    public class Shopper
    {
        public string Name;
        public double account;

        public List<string> Items;

        public Shopper(string Name, double Account = 0)
        {
            this.Name = Name;
            this.account = Account;
            this.Items = new List<string>();
        }

        internal void Purchase(Inventory inventory)
        {

            //if (inventory.price > account)
            //{
            //    Console.WriteLine("Not affordable");
            //}
            //else
            //{
            //    Console.WriteLine(this.Name + " has purshased " + inventory.name + " for Rs." + inventory.price);
            //    this.account -= inventory.price;
            //    Items.Add(inventory.name + " of Price " + inventory.price);
            //}
        }

        public void PrintStatus()
        {


            Console.WriteLine("Remaing Money is account is " + account);

            Console.ReadLine();
        }


    }

}