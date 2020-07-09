using System;

namespace exercise_107
{
    public class PaymentCard
    {
        private double balance;

        public PaymentCard(double openingBalance)
        {
            this.balance = openingBalance;
        // write code here
        }

        public override string ToString()
        {
        // write code here
        return "The card has a balance of " + balance + " euros";
        }
        public void EatLunch()
        {
            this.balance = balance - 10.60;
        }
        public void DrinkCoffee()
        {
            this.balance = balance - 2.0;
        }
    }
}