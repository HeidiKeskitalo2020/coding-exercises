using System;
using System.Collections.Generic;

namespace exercise_88
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
        //int i = 0;
        //while (i < pieces.Length)
        {
          Console.WriteLine(pieces[0]);
        }  
      }  
    }
  }
}



