using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects.BankAccount_Manager
{
    public abstract class BankAccount
    {
        private int _accountNumber;
        private decimal _balance;
        public int AccountNumber
        {
            get => _accountNumber;
            set => _accountNumber = value;
        }
        public decimal Balance
        { 
            get => _balance;
            set => _balance = value;
        }

        protected BankAccount(int accountNumber, decimal balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }
        public abstract void Deposit(decimal amount);
        public abstract void Withdraw(decimal amount);

        public abstract void AccountInfo();

    }
}
