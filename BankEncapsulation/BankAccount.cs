using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double _balance;

        public void Deposit(double moneyToAdd) 
        {
            Console.WriteLine($"Deposit of {moneyToAdd, 0:c} to your account");
            _balance += moneyToAdd;   
        }

        public double GetBalance() 
        {
            return _balance;   
        }
    }
}
