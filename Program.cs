using System;
using System.Collections.Generic;
using System.Linq;

namespace functionalCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fiveUSDs = new Cash("USD", 5m);
            var fiveURDs = new Cash("EUR", 5m);
            var (_, tenUSDs) = fiveUSDs.Add(5m);
            Wallet wallet = new Wallet(new List<IMoney>() { fiveURDs, fiveUSDs, tenUSDs });
            wallet.Print();
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
        public override string ToString() 
        {
            return $"{this.Amount} {this.Currency}";
        }
    }
    
    class Wallet
    {
        public List<IMoney> Contents { get; }
        public Wallet(List<IMoney> contents)
        {
            this.Contents = contents;
        }
    }

    static class ExtensionMethods
    {
        public static void Print(this Wallet wallet)
        {
            wallet
                .Contents
                .ForEach(m => Console.WriteLine(m.ToString()));
        }
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
