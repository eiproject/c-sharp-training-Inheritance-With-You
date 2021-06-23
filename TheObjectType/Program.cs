using System;

namespace TheObjectType
{
  public class Run
  {
    public Run()
    {
      Pict Image1 = new Pict();
      Image1.Filename = "Profil-photo.jpg";

      Pict Image2 = new Pict();
      Image2.Filename = "Dashboard-photo.jpg";

      Pict Image3 = new Pict();
      Image3.Filename = "Header-photo.jpg";

      Pict Image4 = new Pict();
      Image4.Filename = "Footer-photo.jpg";

      Gallery G1 = new Gallery();
      G1.PushData(Image1);
      G1.PushData(Image2);
      G1.PushData(Image3);
      G1.PopData();
      G1.PopData();
      G1.PushData(Image4);

      // Profile and footer left inside
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      /*Console.WriteLine("Hello World!");*/
      Run App = new Run();
    }
  }
}
