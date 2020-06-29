using System;

namespace exercise_61
{
  class Program
  {
    public static void Main(String[] args)
    {
      PrintRightTriangle(4);
    }

    public static void PrintStars(int number)
    {
      int i = 0;
      while (i < number) 
      {
        Console.Write("*");
        i++;
      }
      Console.WriteLine("");
    }

    public static void PrintSpaces(int number)
    {
      int i = 0;
      while (i < number) 
      {
        Console.Write(" ");
        i++;
      }
    }

    public static void PrintRightTriangle(int size)
    {
      int i = 0;
      while (i < size)
      {
        
        PrintStars(i + 1);
        i++;
        PrintSpaces(i);
      }
    }

    public static void ChristmasTree(int height)
    {

    }
  }
}
