using System;
using System.Collections.Generic;

namespace exercise_113
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<Book> list = new List<Book>();
      while (true)
      {
      // IMPLEMENT YOUR CODE IN HERE!
      // Remember also to create the file Book.cs and class in it!
        Console.Write("Name: ");
        string name = Console.ReadLine();
        if (name == "")
        {
          break;
        }
        Console.Write("Pages: ");
        string pages = Console.ReadLine();
        Console.Write("Publication year: ");
        string year = Console.ReadLine();

        list.Add(new Book(name, pages, year));
        }  
        Console.WriteLine("");
        
        Console.Write("What information will be printed? ");
        string what = Console.ReadLine();
        foreach (Book item in list)
        if ( what == "everything")
        {
          Console.WriteLine(item);
        }
        else if ( what == "title")
        {
          Console.WriteLine(item.name);
        }

    }
  }
}


