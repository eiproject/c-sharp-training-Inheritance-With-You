using System;

namespace MarketStock
{
  public class Run
  {
    public Run()
    {
      Book B = new Book("Sejarah", "A5");
      Paper P = new Paper("HVS", "A4");
      Asset theAsset = new Asset();

      // polymorphism
      theAsset.Display(B);
      theAsset.Display(P);

      Console.WriteLine("Book B size is " + B.BookSize);

      // upcast 
      Asset A = B;
      Console.WriteLine($"is A == B : { A == B}");
      /*Console.WriteLine(A.BookSize); // undefined, they are just same in object, but difference access permission*/

      // downcast
      Book B1 = (Book)A;
      Console.WriteLine($"is A == B1 : { A == B1 }");
      Console.WriteLine($"is B == B1 : { B == B1 }");
      Console.WriteLine("Book B1 size is " + B1.BookSize); // OK

      /*
      Paper P1 = (Paper)A; // cannot downcast to difference object 
      Console.WriteLine(P1);
      */

      // the as operator
      Book B2 = new Book("Novel", "B5");
      Asset A2 = new Asset();
      /*Paper P2 = B2 as Paper; // error*/
      Paper P3 = A2 as Paper;
      string P3Name = P3 == null ? "null" : P3.Name;
      Console.WriteLine($"P3 is {P3Name}");
      Asset A3 = B2 as Asset;
      Console.WriteLine($"A3 is {A3.Name}");

    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      Run App = new Run();
    }
  }
}
