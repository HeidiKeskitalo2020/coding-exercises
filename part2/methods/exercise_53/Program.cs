﻿using System;

namespace exercise_53
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
      Division(5, 2);

    }

    // Write your method here:
    public static void Division(int numerator, int denominator)
    {
      //return numerator / denominator;
      
      Console.WriteLine((double)numerator / (double)denominator);
    }
    
  }
}
