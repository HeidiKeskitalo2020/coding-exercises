using System;
using System.Collections.Generic;

namespace exercise_90
{
  class Program
  {
    public static void Main(string[] args)
    {
      int oldest = 0;
      while (true)
      {
        string nameAge = Console.ReadLine();
        if ( nameAge == "")
        {
          break;
        }
        string[] pieces = nameAge.Split(",");
      
        
        //int oldest = nameAge[1];
        //for(int i = 0; i < oldest; i++) 
        if (oldest < Convert.ToInt32(pieces[1])) 
        {
          oldest = Convert.ToInt32(pieces[1]);
        }
      }      
      Console.WriteLine("Age of the oldest: " + oldest);
    }
  }
}



