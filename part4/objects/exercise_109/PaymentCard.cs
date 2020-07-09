using System;

namespace exercise_109
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
            if (balance >= 10.60)
            {
                this.balance = balance - 10.60;
            }
            else
            {
                this.balance = balance + 0;
            }
        }
        public void DrinkCoffee()
        {
            if (balance >= 2.0)
            {
                this.balance = balance - 2.0;
            }
            else
            {
                this.balance = balance + 0;
            }
        }
        public void AddMoney(double amount) 
        {
        // write code here
            //this.amount++;
            if (amount > 0 && amount < 150)
            {
                this.balance = balance  + amount;
            }
            else if (amount > 150)
            {
                this.balance = 150;
            }
        }
    }
}