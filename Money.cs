namespace functionalCSharp
{
  class Cash : IMoney
    {
        public string Currency { get; }
        public decimal Amount { get; }
        public Cash(string currency, decimal amount)
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