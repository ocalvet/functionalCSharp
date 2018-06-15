namespace functionalCSharp
{
  class Amount
  {
    public Currency Currency { get; }
    public decimal Value { get; }
    
    public Amount(Currency currency, decimal amount)
    {
      this.Currency = currency;
      this.Value = amount;
    }

    public override string ToString()
    {
      return $"{this.Value} {this.Currency}";
    }
  }
}