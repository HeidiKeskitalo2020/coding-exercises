using System;
using System.Collections.Generic;

namespace exercise_77
{
  class Program
  {
    public static void Main(string[] args)
    {
      // You can try your method here if you want
      List<string> strings = new List<string>();

      strings.Add("First");
      strings.Add("Second");
      strings.Add("Third");

      // Remember, this is how you print all the items in a list
      strings.ForEach(Console.WriteLine);

      RemoveLast(strings);
      RemoveLast(strings);

      strings.ForEach(Console.WriteLine);
    }
    public static void RemoveLast(List<string> strings)
    {

      if (strings.Count == 0)
      {
        return;
      }
      else 
      {
        //int i = strings.Count -1;
       //
        //{
          int x = 0;
          int i = Convert.ToInt32(x);
          while (i < strings.Count)
          {
            i++;
          }
          //String strings = strings[i];
          strings.RemoveAt(i -1);
          //i = i - 1;
          return;
          
        //}
      }
    }
  }
}


