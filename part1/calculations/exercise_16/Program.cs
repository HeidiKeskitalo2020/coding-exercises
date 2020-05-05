using System;

namespace exercise_16
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("How many days?");
      string message = Console.ReadLine();
      int days = Convert.ToInt32(message);
      Console.WriteLine(days * 86400);

    }
  }
}
