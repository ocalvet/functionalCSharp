using System.Collections.Generic;

namespace functionalCSharp
{
  class Wallet
    {
        public List<IMoney> Contents { get; }
        public Wallet(List<IMoney> contents)
        {
            this.Contents = contents;
        }
    }

}