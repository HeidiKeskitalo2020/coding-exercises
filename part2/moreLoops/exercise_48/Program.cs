using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {
      
      // Write your code here:
      Console.WriteLine("Give numbers: ");
      int sum = 0;
      int amount = 0;
      int even = 0;
      int odd = 0;
      
      while (true)
      {
        int number = Convert.ToInt32(Console.ReadLine());
        
        if (number == -1)
        {
          break;
        }
       
        sum = sum + number;
        amount++;
        if ((number % 2) == 0)
        {
          even++;
        }
        else
        {
          odd++;
        }
      }
      
      Console.WriteLine("Thx! Bye!");
      Console.WriteLine("Sum: " + sum);
      Console.WriteLine("Numbers: " + amount);
      Console.WriteLine("Avarage: " + (double)sum / amount);
      Console.WriteLine("Even: " + even);
      Console.WriteLine("Odd: " + odd);
    }
  }
}
