using System;

namespace exercise_37
{
  class Program
  {
    public static void Main(string[] args)
    {
      int sum = 0;
      // Write your code here:
      while (true)
      {
      // Write your code here:
        Console.WriteLine("Give a number:");
        string input = Console.ReadLine();
        int number = Convert.ToInt32(input);

        if (number == 0)
        {
         break;
        }
        sum++;
      }  
      Console.WriteLine("Total amount of numbers: " + sum);
    }
  }
}
