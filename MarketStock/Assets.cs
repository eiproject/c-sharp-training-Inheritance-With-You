using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStock
{
  class Asset
  {
    internal string Name;
    internal virtual decimal Price => 999;
    internal Asset()
    {

    }
    internal void Display(Asset asset)
    {
      Console.WriteLine($"Product name: {asset.Name}");
    }

    internal virtual void checkCondition()
    {
      Console.WriteLine("Asset Virtual Void Method");
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
    internal override void checkCondition()
    {
      Console.WriteLine("Paper Overide Void Method");
    }
  }

  class Motocycle : Asset
  {
    internal decimal motocyclePrice;
    internal override decimal Price => base.Price + motocyclePrice; // OK
    /*internal override decimal Price => Price + motocyclePrice; // Stack Overflow*/
    /*internal override decimal Price => this.Price + motocyclePrice; // Stack Overflow*/
    internal string platMotor;
    internal new void checkCondition()
    {
      Console.WriteLine("Motocycle New Void Method");
    }
  }
}
