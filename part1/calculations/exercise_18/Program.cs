using System;

namespace exercise_18
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
      Console.WriteLine("Give the third number!");
      string third = Console.ReadLine();
      int thirdNumber = Convert.ToInt32(third);
      
      int sum = firstNumber + secondNumber + thirdNumber;
      Console.WriteLine("The sum is " + sum);
    }
  }
}
