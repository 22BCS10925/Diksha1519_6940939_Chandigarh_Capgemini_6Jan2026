using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountSystem
{
    public class BankAccounts
    {
        public decimal Balance { get; private set; }

        public BankAccounts(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
                throw new InvalidOperationException("Insufficient funds");

            Balance -= amount;
        }
    }
}