using System;

namespace exercise_22
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give the first number!");
      string first = Console.ReadLine();
      double firstNumber = Convert.ToDouble(first);

      Console.WriteLine("Give the second number!");
      string second = Console.ReadLine();
      double secondNumber = Convert.ToDouble(second);

      Console.WriteLine("Give the third number!");
      string third = Console.ReadLine();
      double thirdNumber = Convert.ToDouble(third);
      
      double average = (firstNumber + secondNumber + thirdNumber) / 3;
      Console.WriteLine("The average is " + average);
    }
  }
}
