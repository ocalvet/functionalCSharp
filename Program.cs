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
    }
}
