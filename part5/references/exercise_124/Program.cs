using System;

namespace exercise_124
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Implement your program here!
      Person bill = new Person("Bill Boat", 2); 
      Console.WriteLine(bill);

      Person Jaana = bill;
      Jaana.GrowOlder();
      Jaana.GrowOlder();


      Console.WriteLine(Jaana);
      Jaana = new Person ("Billly B.", 1);
      Console.WriteLine(Jaana);

      Jaana = null;
      Console.WriteLine(Jaana);
      Jaana.GrowOlder();
      
    }
  }
}
