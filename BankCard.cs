using System;

namespace functionalCSharp
{
  class BankCard : IMoney
  {
    public Currency Currency { get; }
    public decimal Amount { get; }
    public DateTime Expiration { get; }
    public BankCard(Currency currency, decimal amount, DateTime expiration)
    {
      this.Currency = currency;
      this.Amount = amount;
      this.Expiration = expiration;
    }
    public override string ToString()
    {
      return $"{this.Amount} {this.Currency}";
    }
  }

}