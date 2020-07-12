using System;

namespace exercise_115
{
  class Program
  {
    public static void Main(string[] args)
    {
      //int sum = 0;
      while (true)
      {
        string number = Console.ReadLine();

        if (number == "end") 
        {
          break;
        }
        int numbers = Convert.ToInt32(number);
        //sum++;
        Console.WriteLine(numbers * numbers * numbers);        
      }
      
    }
  }
}
