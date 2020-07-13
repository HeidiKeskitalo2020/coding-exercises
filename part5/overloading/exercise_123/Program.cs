using System;

namespace exercise_123
{
  class Program
  {
    public static void Main(string[] args)
    {
      // You can test your code here.
      Counter counter = new Counter(10);
      counter.Increase();
      Console.WriteLine(counter);
      counter.Increase(10);
      counter.Decrease(5);
      Console.WriteLine(counter);
      counter.Increase(1);
      Console.WriteLine(counter);
      
    }
  }
}
