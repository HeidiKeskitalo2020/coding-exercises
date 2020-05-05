using System;

namespace exercise_40
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int sum = 0;
      int amount = 0;
     
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
        amount++;
                
      }  
      Console.WriteLine("Total sum of numbers: " + sum);
      Console.WriteLine("Total amount of numbers: " + amount);
    }
  }
}
