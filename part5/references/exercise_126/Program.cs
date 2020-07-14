using System;

namespace exercise_126
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Try your code here, if you want

      // Part 1.
      /*PaymentCard petesCard = new PaymentCard(10);

      Console.WriteLine("money " + petesCard.balance);
      bool wasSuccessful = petesCard.TakeMoney(8);
      Console.WriteLine("successfully withdrew: " + wasSuccessful);
      Console.WriteLine("money " + petesCard.balance);

      wasSuccessful = petesCard.TakeMoney(4);
      Console.WriteLine("successfully withdrew: " + wasSuccessful);
      Console.WriteLine("money " + petesCard.balance);*/

      // Part 2.
      /*PaymentTerminal lunchCafeteria = new PaymentTerminal();

      double change = lunchCafeteria.DrinkCoffee(10);
      Console.WriteLine("remaining change " + change);

      change = lunchCafeteria.DrinkCoffee(5);
      Console.WriteLine("remaining change " + change);

      change = lunchCafeteria.EatLunch(20);
      Console.WriteLine("remaining change " + change);

      Console.WriteLine(lunchCafeteria);*/

      //Part 3.
      /*PaymentTerminal lunchCafeteria = new PaymentTerminal();

      double change = lunchCafeteria.DrinkCoffee(10);
      Console.WriteLine("remaining change: " + change);

      PaymentCard annesCard = new PaymentCard(15);

      bool wasSuccessful = lunchCafeteria.EatLunch(annesCard);
      Console.WriteLine("there was enough money: " + wasSuccessful);
      wasSuccessful = lunchCafeteria.EatLunch(annesCard);
      Console.WriteLine("there was enough money: " + wasSuccessful);
      wasSuccessful = lunchCafeteria.DrinkCoffee(annesCard);
      Console.WriteLine("there was enough money: " + wasSuccessful);

      Console.WriteLine(lunchCafeteria);*/

      // Part 4.
      PaymentTerminal lunchCafeteria = new PaymentTerminal();
      Console.WriteLine(lunchCafeteria);

      PaymentCard annesCard = new PaymentCard(2);

      Console.WriteLine("amount of money on the card is " + annesCard.balance + " euros");

      bool wasSuccessful = lunchCafeteria.EatLunch(annesCard);
      Console.WriteLine("there was enough money: " + wasSuccessful);

      lunchCafeteria.AddMoneyToCard(annesCard, 100);

      wasSuccessful = lunchCafeteria.EatLunch(annesCard);
      Console.WriteLine("there was enough money: " + wasSuccessful);

      Console.WriteLine("amount of money on the card is " + annesCard.balance + " euros");

      Console.WriteLine(lunchCafeteria);
    }
  }
}
