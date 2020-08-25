namespace Exercise
{
  using System;
  using System.Collections.Generic;
  public class TextInterface
  {
    
    // Create the userinterface here
    private List<Book> books;
    public TextInterface()
    {
      this.books = new List<Book>();
    }

    public void Start()
    {
      while(true)
      {
        Console.WriteLine("Input the name of the book, empty stops:");
        string book = Console.ReadLine();
        
        if (book == "")
        {
          break;
        }
        Console.WriteLine("Input the age recommendation:");
        int age = Convert.ToInt32(Console.ReadLine());
        this.books.Add(new Book (book, age));
      }
      Console.WriteLine(this.books.Count + " books in total.");
      Console.WriteLine("");
      Console.WriteLine("Books:");
      books.Sort();
      this.books.ForEach(Console.WriteLine); //(Book book in books)
      /*{
        Console.WriteLine(book + " (recommended for " + age + "year-olds or older)" + "\n");
      }*/
    }
  }
}