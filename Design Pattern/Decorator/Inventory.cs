using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using System.Xml.Schema;

namespace Design_Pattern.Decorator
{
    public class Inventory
    {
        public string ProductName { get; set; }
        public double Price { get; set; }

        public int Count { get; set; }

    }
}
