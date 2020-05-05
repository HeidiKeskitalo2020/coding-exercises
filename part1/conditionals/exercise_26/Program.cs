using System;

namespace exercise_26
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give your age:");
      string number = Console.ReadLine();
      int age = Convert.ToInt32(number);

      if (age < 1900) 
      {
         Console.WriteLine("You're old");
      }
    }
  }
}
