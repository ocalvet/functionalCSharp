using System;
using System.Collections.Generic;
using System.Linq;

namespace functionalCSharp
{
  static class ExtensionMethods
  {
    public static void Print(this Wallet wallet)
    {
      wallet
          .Contents
          .ToList()
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

    public static IEnumerable<IMoney> Of(this IEnumerable<IMoney> moneys, Currency currency)
    {
        return new List<IMoney>();
    }

    public static Wallet Charge(this IEnumerable<IMoney> moneys, Amount amount)
    {
        return new Wallet(new List<IMoney>());
    }
  }
}