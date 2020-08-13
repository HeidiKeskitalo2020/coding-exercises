using System;
using System.Collections.Generic;

namespace exercise_136
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Person ada = new Person("Ada Lovelace");
      Person jack = new Person("Jack The Ripper");
      Person mike = new Person("Mike The Incredible Magic Mouse");

      HowManyNames(ada);
      HowManyNames(jack);
      HowManyNames(mike);
      
    }
    public static void HowManyNames(Person person) 
    {
      string name = person.ToString();
      int namePiece = name.Split(" ").Length;
      Console.WriteLine(name + " has " + namePiece + " names.");
    }
  
    // Do something here
  }
}