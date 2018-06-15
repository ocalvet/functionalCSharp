using System.Collections.Generic;

namespace functionalCSharp
{
  static class WalletBehavior 
  {
    public static Wallet Pay(this Wallet wallet, Amount amount, Currency currency)
    {
      var newWallet = wallet
        .Contents
        .Of(amount.Currency)
        .Charge(amount);

      return newWallet;
    }
  }
}