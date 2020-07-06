using System;

namespace exercise_94
{
  class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT TOUCH THE OTHER FILE!
      // Do your code here!
      Account heikkisAccount = new Account("Heikki's account", 1000.00);
      Account personalAccount = new Account("Personal account", 0);

      heikkisAccount.Withdrawal(100);
      //Console.WriteLine("The balance of Heikki's account is now: " + heikkisAccount.balance);
      personalAccount.Deposit(100);
      //Console.WriteLine("The balance of Heikki's other account is now: " + heikkisSwissAccount.balance);

      //Console.WriteLine("End state");
      Console.WriteLine(heikkisAccount);
      Console.WriteLine(personalAccount);
    }
  }
}



