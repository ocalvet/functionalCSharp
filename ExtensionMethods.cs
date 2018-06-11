using System;

namespace functionalCSharp
{
  static class ExtensionMethods
  {
    public static void Print(this Wallet wallet)
    {
      wallet
          .Contents
          .ForEach(m => Console.WriteLine(m.ToString()));
    }
    public static (Currency currency, IMoney money) Add(this IMoney money, decimal amount)
    {
      switch (money)
      {
        case Cash cash:
          return (cash.Currency, new Cash(cash.Currency, cash.Amount + amount));
        default:
          return (null, null);
      }
    }
  }
}