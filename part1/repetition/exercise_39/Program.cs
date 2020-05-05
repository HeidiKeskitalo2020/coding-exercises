using System;

namespace exercise_39
{
  class Program
  {
    public static void Main(string[] args)
    {
      int sum = 0;
     
      while (true)
      {
        
        Console.WriteLine("Give a number:");
        string input = Console.ReadLine();
        int number = Convert.ToInt32(input);

        if (number == 0)
        {
         break;
        }
        sum = sum + number;
        
      }  
      Console.WriteLine("Total sum of numbers: " + sum);
    }
  }
}
