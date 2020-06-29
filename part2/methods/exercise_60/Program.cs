using System;

namespace exercise_60
{
  class Program
  {
    public static void Main(String[] args)
    {
      /*PrintStars(5);
      PrintStars(3);
      PrintStars(9);*/
      //PrintSquare(4);
      //PrintRectangle(17, 3);
      PrintTriangle(4);
    }


    public static void PrintStars(int number)
    {
      // you can print one star with the command
      // Console.Write("*");
      // call the print command n times
      // in the end print a line break with the comand
      // Console.WriteLine("");
      int i = 0;
      while (i < number) 
      {
        Console.Write("*");
        i++;
      }
      Console.WriteLine("");
    }

    public static void PrintSquare(int size)
    {
      int number = 1; //for (int i = 0; i < size; i++)
      while (number <= size)
      {
        PrintStars(size);
        number++;
      }
    }

    public static void PrintRectangle(int width, int height)
    {
      for (int i = 0; i < height; i++)
      {
        //for (int j = 0; j < height; j++)
        PrintStars(width);
        //width++;
      }
    }

    public static void PrintTriangle(int size)
    {
      //for (int i = 0; i < size; i++)
      int i = 0;
      while (i < size)
      {
        PrintStars(i + 1);
        i++;
      }
    }    
  }
}
