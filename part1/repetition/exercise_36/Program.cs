using System;

namespace exercise_36
{
  class Program
  {
    public static void Main(string[] args)
    {
      while (true)
      {
      // Write your code here:
        Console.WriteLine("Give a number:");
        string input = Console.ReadLine();
        int number = Convert.ToInt32(input);

        int multip = number * number;
      
         if (number < 0)
        { 
          Console.WriteLine("That is negative");
        }
        if (number > 0)
        {
          Console.WriteLine(multip);
        }
        if (number == 0)
        {
         break;
        }
      }  
    }
  }
}
