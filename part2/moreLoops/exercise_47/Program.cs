using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Where to?");
      int number1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Where from?");
      int number2 = Convert.ToInt32(Console.ReadLine());
      for (int i = number2; i <= number1; i++) 
      {
        Console.WriteLine(i);
      }
    }
  }
}
