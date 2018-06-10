using System;
using System.Collections.Generic;

namespace functionalCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IMoney> wallet = new List<IMoney>();
            var fiveUSDs = new Cash("$", 5m);
            var (_, tenUSDs) = fiveUSDs.Add(5m);
            Console.WriteLine($"Todal moneys {fiveUSDs}, {tenUSDs}");
        }
        public static (string name, int age) Who() {
            return ("Ovidio", 23);
        }
    }

    interface IMoney  {}
    class Cash : IMoney
    {
        public string Currency { get; }
        public decimal Amount { get; }
        public Cash(string currency, decimal amount)
        {
            this.Currency = currency;
            this.Amount = amount;
        }
    }

    static class ExtensionMethods
    {
        public static (string currency, IMoney money) Add(this IMoney money, decimal amount)
        {
            switch(money) 
            {
                case Cash cash:
                    return (cash.Currency, new Cash(cash.Currency, cash.Amount + amount));
                default:
                    return (String.Empty, new Cash(String.Empty, 0m));
            }
        } 
    }

}
