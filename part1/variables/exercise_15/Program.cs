using System;

namespace exercise_15
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give a string:");
      string message = Console.ReadLine();
      Console.WriteLine("Give an integer:");
      string integer = Console.ReadLine();
      int  intValue = Convert.ToInt32(integer);
      Console.WriteLine("Give a double:");
      string number =Console.ReadLine();
      double doubleNumbers = Convert.ToDouble(number);
      Console.WriteLine("Give a boolean:");
      string boolean = Console.ReadLine();
      bool booleanValue = System.Convert.ToBoolean(boolean);
      Console.WriteLine("Your string: " + message);
      Console.WriteLine("Your integer: " + integer);
      Console.WriteLine("Your double: " + number);
      Console.WriteLine("Your boolean: " + booleanValue);
      
    }
  }
}
