using System;

namespace exercise_42
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int first = Convert.ToInt32(Console.ReadLine());
      int second = Convert.ToInt32(Console.ReadLine());
      double squareRoot = Math.Sqrt(first + second);
      Console.WriteLine(squareRoot);
    }
  }
}
