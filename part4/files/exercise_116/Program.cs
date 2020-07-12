using System;
using System.IO;

namespace exercise_116
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Read the file data.txt and print the text from it as it is
      // You can use either File.ReadAllText or File.ReadAllLines
      string[] lines = File.ReadAllLines("data.txt");

      // Display the file contents by using a foreach loop.
      foreach (string line in lines)
      {
        //string[] pieces = line.Split(" ");
        //string first = pieces[0];
        //string second = pieces[1];
        Console.WriteLine(line);
        //Console.WriteLine(line);
        //Tehtävän annossa on virhe, se pyyttää printtaamaan 
        //vain 2 ensimmäistä riviä!
      }
    
    }
  }
}
