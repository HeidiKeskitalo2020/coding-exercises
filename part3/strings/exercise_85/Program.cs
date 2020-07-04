using System;
using System.Collections.Generic;

namespace exercise_85
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Enter username:");
      string userName = Console.ReadLine();
      Console.WriteLine("Enter password:");
      string password = Console.ReadLine();

      if ( userName == "alex" && password == "sunshine" || userName == "emma" && password == "haskell")
      {
        Console.WriteLine("You have successfully logged in!");
      }
      else
      {
        Console.WriteLine("Incorrect username or password!");
      }

    }
  }
}

