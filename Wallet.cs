using System.Collections.Generic;

namespace functionalCSharp
{
  class Wallet
  {
    public IEnumerable<IMoney> Contents { get; }
    public Wallet(IEnumerable<IMoney> contents)
    {
      this.Contents = contents;
    }
  }

  static class WalletExtensionMethods 
  {
    public static Wallet Charge(this Wallet wallet, Amount amount, Currency currency)
    {
      return new Wallet(new List<IMoney>());
    }
  }
}