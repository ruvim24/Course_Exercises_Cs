using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects.BankAccount_Manager
{
    internal class CheckingAccount : BankAccount
    {
        private decimal _overdraftLimit;
        public decimal OverdraftLimit
        {
            get => _overdraftLimit;
            private set => _overdraftLimit = value;
        }

        public CheckingAccount(int accountNumber, decimal balance, decimal overdraftLimit) : base(accountNumber, balance) 
        {
            OverdraftLimit = overdraftLimit;
        }
        public override void Deposit(decimal amount)
        {
            Console.WriteLine($"Balance: {Balance}");
            Balance += amount;
            Console.WriteLine("Updated Balance: {Balance}");
        }
        public override void Withdraw(decimal amount)
        {
            if (amount > Balance + OverdraftLimit)
            {
                Console.WriteLine($"Can't withdraw. Max posibile withdraw: {Balance + OverdraftLimit}");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine($"You withdrew succesdfully: {amount}\nCurrent Balance: {Balance}");
            }
        }

        public override void AccountInfo()
        {
            Console.WriteLine("___________________________________");
            Console.WriteLine("\tAccount information");
            Console.WriteLine($"Type: {GetType().Name}");
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Balance: {Balance}");
            Console.WriteLine($"Overdraft Limit:  {OverdraftLimit}");
            Console.WriteLine("___________________________________");
        }
    }
}
