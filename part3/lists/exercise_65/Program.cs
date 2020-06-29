using System;
using System.Collections.Generic;

namespace exercise_65
{
  class Program
  {
    public static void Main(string[] args)
    {
      int amount = 0;

      List<string> list = new List<string>();
      while (true)
      {
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }
        amount++;
        list.Add(input);
      }
      Console.WriteLine("In total: " + amount);
    }
  }
}
