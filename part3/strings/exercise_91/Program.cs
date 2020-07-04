using System;
using System.Collections.Generic;

namespace exercise_91
{
  class Program
  {
    public static void Main(string[] args)
    {
      int oldest = 0;
      string oldestName = "";
      while (true)
      {
        string nameAge = Console.ReadLine();
        if ( nameAge == "")
        {
          break;
        }
        string[] pieces = nameAge.Split(",");
      
        if (oldest < Convert.ToInt32(pieces[1])) 
        {
          oldest = Convert.ToInt32(pieces[1]);
          oldestName = pieces[0];
        }
      }      
      Console.WriteLine("Name of the oldest: " + oldestName);
    }
  }
}



