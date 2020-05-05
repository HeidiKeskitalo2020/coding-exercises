using System;

namespace exercise_17
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give the first number!");
      string first = Console.ReadLine();
      int firstNumber = Convert.ToInt32(first);
      Console.WriteLine("Give the second number!");
      string second = Console.ReadLine();
      int secondNumber = Convert.ToInt32(second);
      
      int sum = firstNumber + secondNumber;
      Console.WriteLine("The sum is " + sum);
    }
  }
}
