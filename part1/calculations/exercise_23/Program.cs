using System;

namespace exercise_23
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

      double sum = firstNumber + secondNumber;
      double minus = firstNumber - secondNumber;
      double multi = firstNumber * secondNumber;
      double average = firstNumber / secondNumber;


      Console.WriteLine(first + " + " + second + " = " + sum);
      Console.WriteLine(first + " - " + second + " = " + minus);  
      Console.WriteLine(first + " * " + second + " = " + multi);
      Console.WriteLine(first + " / " + second + " = " + average);    
    }
  }
}
