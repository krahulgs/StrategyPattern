using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public class Client
    {
        public void StartTransaction(IBank bank)
        {
            bank.Request();
        }
    }
}
