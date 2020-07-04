using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            Console.WriteLine("Client: Executing the Transaction with a real Bank");
            Client client = new Client();
            client.StartTransaction(bank);

            Console.WriteLine("====================================================");

            Console.WriteLine("Client: Executing the Transaction with Credit Card");
            CreditCardProxy ccProxy = new CreditCardProxy(bank);
            client.StartTransaction(ccProxy);

            Console.WriteLine("====================================================");

            Console.WriteLine("Client: Executing the Transaction with Debit Card");
            DebitCardProxy dcProxy = new DebitCardProxy(bank);
            client.StartTransaction(dcProxy);
        }
    }
}
