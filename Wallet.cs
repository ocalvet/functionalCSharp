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
    
    public override string ToString()
    {
      string str = string.Empty;
      foreach(var money in this.Contents)
      {
        str += $"{money.ToString()}\n";
      }
      return str;
    }
  }
}