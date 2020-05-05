using System;

namespace exercise_38
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
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
        if (number < 0)
        {
          sum++;
        }  
      }  
      Console.WriteLine("Total amount of negative numbers: " + sum);
    }
  }
}
