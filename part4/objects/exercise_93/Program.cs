using System;

namespace exercise_93
{
  class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT TOUCH THE OTHER FILE!
      // Do your code here!
      Account heikkisAccount = new Account("Heikki's account", 100.00);
      

      heikkisAccount.Deposit(20);
      Console.WriteLine(heikkisAccount.balance);
      
      
     
    }
  }
}



