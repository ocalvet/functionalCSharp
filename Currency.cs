namespace functionalCSharp
{
  class Currency
  {
    public string Symbol { get; }

    public Currency(string symbol)
    {
      this.Symbol = symbol;
    }

    public override string ToString()
    {
      return this.Symbol.ToUpper();
    }
  }
}