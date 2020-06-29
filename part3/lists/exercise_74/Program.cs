using System;
using System.Collections.Generic;

namespace exercise_74
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> list = new List<string>();
      while (true)
      {
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }
        list.Add(input);
      }
      Console.WriteLine("Search for?");
      string input2 = Console.ReadLine();

      
      //for ( int i = 0; i < list.Count; i++)
      {
        //string words  = list[i];
        if (list.Contains (input2))
        {
          Console.WriteLine(input2 + " was found!");
        }
        else 
        {
          Console.WriteLine(input2 + " was not found!");
        }
      }
    }  
  }
}

