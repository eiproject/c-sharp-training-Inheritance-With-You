using System;

namespace TrainingFullInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello Inheritance !");
      MarketStock.Run app1 = new MarketStock.Run();
      TheObjectType.Run app2 = new TheObjectType.Run();
    }
  }
}
