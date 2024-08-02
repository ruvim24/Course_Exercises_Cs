using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects.BankAccount_Manager
{
    internal class SavingsAccounts : BankAccount
    {
        private float _interestRate;
        public float InterestRate
        {
            get => _interestRate; 
            set => _interestRate = value;
        }

        public SavingsAccounts(int accountNumber, decimal balance, float interestRate) : base(accountNumber, balance) 
        {
            InterestRate = interestRate;
            Balance = balance + (balance * (decimal)InterestRate);
        }
        public override void Deposit(decimal amount)
        {
            Console.WriteLine($"Balance: {Balance}");
            decimal tempAmount = amount + (amount * (decimal)InterestRate);
            Balance += tempAmount;
            Console.WriteLine("Updated Balance: {Balance}");
        }
        public override void Withdraw(decimal amount)
        {
            if(amount > Balance)
            {
                Console.WriteLine("Can't witdraw this amount!");
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
            Console.WriteLine($"Interest Rate:  {InterestRate}");
            Console.WriteLine("___________________________________");
        }
    }
}

//Sold final = Sold initial + (Sold initial * Rata dobânzii * Timp)