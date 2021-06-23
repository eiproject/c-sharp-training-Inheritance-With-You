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
      Console.WriteLine($"P3 Name is {P3Name}");
      Asset A3 = B2 as Asset;
      Console.WriteLine($"A3 Name is {A3.Name}");
      
      // the is operator
      if (A3 is Asset)
      {
        Console.WriteLine("A3 is Asset");
      }
      else
      {
        Console.WriteLine("A3 is not Asset");
      }

      if (A3 is Book)
      {
        Console.WriteLine("A3 is Book");
      }
      else
      {
        Console.WriteLine("A3 is not Book");
      }

      if (P3 is Book)
      {
        Console.WriteLine("P3 is Book");
      }
      else
      {
        Console.WriteLine("P3 is not Book");
      }

      // virtual function member
      Motocycle Jup = new Motocycle {
        Name = "M",
        motocyclePrice = 5500,
        platMotor = "H 5224 B"
      };
      Asset No1 = Jup;
      Console.WriteLine(Jup.Price);
      Console.WriteLine(No1.Price);
      Console.WriteLine(Jup.platMotor);
      /*Console.WriteLine(No1.platMotor); // error*/

      // Abstract class and abstract member
      Tool T1 = new Tool { toolName = "Solder", weight = 1 };
      Tool T2 = new Tool { toolName = "Stone", weight = 7 };
      Console.WriteLine($"T1.Size {T1.Size}");
      Console.WriteLine($"T2.Size {T2.Size}");

      // new vs override
      Paper P2 = new Paper(paperName:"Karton", size:"A3");
      Motocycle M2 = new Motocycle();
      Asset P2ToAsset = P2;
      Asset M2ToAsset = M2;

      P2.checkCondition();
      P2ToAsset.checkCondition();
      M2.checkCondition();
      M2ToAsset.checkCondition();

      // base 
      Motocycle M3 = new Motocycle { motocyclePrice = 4000, platMotor="H 2222 N"};
      Console.WriteLine(M3.Price);

      // constructor, inheritance
      Detail D1 = new Detail("Narnia");
      Console.WriteLine(D1.Title);

      Genre G1 = new Genre("Harry Potter", "Magic");
      Console.WriteLine(G1.Title);
      Console.WriteLine(G1.Genre);

      Movie M = G1;
      CheckData(M);
      CheckData(D1);
    }

    static void CheckData(Movie a)
    {
      Console.WriteLine("Movie: " + a.Title);
    }

    static void CheckData(Detail a)
    {
      Console.WriteLine("Detail: " + a.Title);
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
