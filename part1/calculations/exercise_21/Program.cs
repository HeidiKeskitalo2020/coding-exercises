using System;

namespace exercise_21
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
      
      double average = (firstNumber + secondNumber) / 2;
      Console.WriteLine("The average is " + average);
    }
  }
}
