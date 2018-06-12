namespace functionalCSharp
{
  class Cash : IMoney
  {
    public Currency Currency { get; }
    public decimal Amount { get; }
    public Cash(Currency currency, decimal amount)
    {
      this.Currency = currency;
      this.Amount = amount;
    }
    public override string ToString()
    {
      return $"{this.Amount} {this.Currency}";
    }
  }
}