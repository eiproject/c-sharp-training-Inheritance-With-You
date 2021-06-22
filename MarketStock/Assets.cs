using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStock
{
  class Asset
  {
    internal string Name;
    internal Asset()
    {

    }
    internal void Display(Asset asset)
    {
      Console.WriteLine($"Product name: {asset.Name}");
    }
  }

  class Book : Asset
  {
    string bookSize;
    internal Book(string bookName, string size)
    {
      Name = bookName;
      bookSize = size;
    }

    internal string BookSize { get { return bookSize; } }
  }

  class Paper : Asset
  {
    string paperSize;
    internal Paper(string paperName, string size)
    {
      Name = paperName;
      paperSize = size;
    }
    internal string PaperSize { get { return paperSize; } }
  }

}
