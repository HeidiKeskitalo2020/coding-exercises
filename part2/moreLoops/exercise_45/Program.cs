using System;

namespace exercise_45
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int number1 = Convert.ToInt32(Console.ReadLine());
      int number2 = 0;

      while (number2 < number1 + 1) 
      {
        Console.WriteLine(number2);
        number2++;
      }
    }
  }
}
