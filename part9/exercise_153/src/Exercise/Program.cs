using System;
using System.Collections.Generic;

namespace Exercise
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Book book1 = new Book("Fedor Dostojevski", "Crime and Punishment", 1866);
      Book book2 = new Book("Robert Martin", "Clean Code", 2008);
      Book book3 = new Book("Kent Beck", "Test Driven Development", 2000);

      Furniture sofa = new Furniture("Sofa", "Red", 20);
      Furniture bed = new Furniture("Twin bed", "White", 15);
      Furniture table = new Furniture("Dining room table", "Oak", 30);

      /*List<IPackable> packages = new List<IPackable>();
      packages.Add(book1);
      packages.Add(book2);
      packages.Add(book3);
      packages.Add(sofa);
      packages.Add(bed);
      packages.Add(table);

      packages.ForEach(Console.WriteLine);*/

      //2.osa
      /*Box box = new Box(40);
      box.Add(book1);
      box.Add(book2);
      box.Add(book3);
      box.Add(sofa);
      box.Add(bed);
      box.Add(table);

      Console.WriteLine(box);*/

      // 3.osa
      Box bookBox = new Box(5);
      bookBox.Add(book1);
      bookBox.Add(book2);
      bookBox.Add(book3);

      Console.WriteLine(bookBox);
      Console.WriteLine();

      Box movingVan = new Box(800);
      movingVan.Add(bookBox);
      movingVan.Add(sofa);
      movingVan.Add(bed);
      movingVan.Add(table);

      Console.WriteLine(movingVan);
      Console.WriteLine();

      Box shippingContainer = new Box(3000);
      shippingContainer.Add(movingVan);

      Console.WriteLine(shippingContainer);
    }
  }
}

