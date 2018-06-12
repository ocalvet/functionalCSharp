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

}