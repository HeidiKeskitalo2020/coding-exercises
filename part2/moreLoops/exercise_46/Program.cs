using System;

namespace exercise_46
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int number1 = Convert.ToInt32(Console.ReadLine());
      //int number2 = 100;

      while (number1 < 100 + 1) 
      {
        Console.WriteLine(number1);
        number1++;
      }
    }
  }
}
