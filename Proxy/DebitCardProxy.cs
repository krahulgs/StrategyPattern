using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    class DebitCardProxy : IBank
    {
        public IBank Bank { get; }

        public DebitCardProxy(IBank bank)
        {
            this.Bank = bank;
        }

        public void Request()
        {
            if (this.CheckAccess())
            {
                this.Bank.Request();
                this.LogAccess();
            }
        }

        private void LogAccess()
        {
            Console.WriteLine("Credit Card Proxy: Logging the time of request.");
        }

        private bool CheckAccess()
        {
            Console.WriteLine("Credit Card Proxy: Checking access prior to firing a real request.");
            return true;
        }
    }
}
