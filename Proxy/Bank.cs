using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    class Bank : IBank
    {
        public void Request()
        {
            Console.WriteLine("Bank: Handling Request.");
        }
    }
}
