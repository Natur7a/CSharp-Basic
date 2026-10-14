using System;
using System.Collections.Generic;
using System.Text;

namespace Sesi1
{
    public class Savings
    {
        private double balance;

        public void Withdraw(double amount)
        {
            if(balance >= amount)
            {
                balance -= amount;
                Console.WriteLine(amount + " withdrawn. New balance: " + balance);
            }else if(balance < amount)
            {
                Console.WriteLine("Insufficient balance. Current balance: " + balance);
            }
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}
