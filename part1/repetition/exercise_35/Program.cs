using System;

namespace exercise_35
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
       while (true)
      {
        
        Console.WriteLine("Give a number:");
        string input = Console.ReadLine();
        int number = Convert.ToInt32(input);
        if (number == 42)
        {
          break;
        }
      }  
    }
  }
}
