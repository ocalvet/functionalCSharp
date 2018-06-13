﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace functionalCSharp
{
  class Program
  {
    static void Main(string[] args)
    {
      var dollar = new Currency("USD");
      var euro = new Currency("EUR");
      IEnumerable<IMoney> moneys = new List<IMoney>()
      {
        new Cash(dollar, 5m),
        new Cash(euro, 15m),
        new Cash(euro, 5m),
        new BankCard(dollar, 100m, new DateTime(2020, 06, 30))
      };
      Wallet wallet = new Wallet(moneys);
      wallet.Charge(10m, dollar);
      wallet.Print();
    }
  }
}
