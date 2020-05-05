using System;

namespace exercise_29
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

      if (firstNumber > secondNumber)
      {
        Console.WriteLine("The larger number is " + firstNumber + "!");
      }
      else if (firstNumber < secondNumber)
      {
        Console.WriteLine("The larger number is " + secondNumber + "!");
      }
      else if (firstNumber == secondNumber)
      {
        Console.WriteLine("They are equal!");
      }
    }
  }
}
