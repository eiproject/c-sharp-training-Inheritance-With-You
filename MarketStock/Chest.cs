using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStock
{
  class Tool : Chest
  {
    internal string toolName;
    internal int weight;
    internal override string Size
    {
      get
      {
        string theSize;
        if (weight > 5)
        {
          theSize = "Big";
        }
        else
        {
          theSize = "Small";
        }
        return theSize;
      }
    }
  }
  abstract class Chest
  {
    internal abstract string Size { get; }
  }
}
