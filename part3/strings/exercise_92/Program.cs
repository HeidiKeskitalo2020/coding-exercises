using System;
using System.Collections.Generic;

namespace exercise_92
{
  class Program
  {
    public static void Main(string[] args)
    {
      int oldest = 2020;
      int lenght = 0;
      string longestName = "";
      int age = 0;
      int nameLenght = 0;

      while (true)
      {
        string nameAge = Console.ReadLine();
        if ( nameAge == "")
        {
          break;
        }
        string[] pieces = nameAge.Split(",");
      
        if (oldest > (Convert.ToInt32(pieces[1])))
        {
          oldest = Convert.ToInt32(pieces[1]);
        }
        string word = pieces[0];
        lenght = word.Length;
        if (lenght > nameLenght)
        {
          nameLenght = lenght;
          longestName = pieces[0];
        }
      }
      age = 2020 - oldest;
         
      Console.WriteLine("Longest name: " + longestName);
      Console.WriteLine("Highest age: " + age);
    }
  }
}



