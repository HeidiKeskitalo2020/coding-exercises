using System;
using System.Collections.Generic;

namespace exercise_89
{
  class Program
  {
    public static void Main(string[] args)
    {
       while (true)
      {
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }
        string[] pieces = input.Split(" ");
        //for (int i = 0; i < pieces.Length; i++)
        {
          int lastWord = pieces.Length;
          Console.WriteLine(pieces[lastWord -1]);
        }  
      }  

    }
  }
}



