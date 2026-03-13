using BankAccountSystem;
using System;

namespace BankAccountSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccounts account = new BankAccounts(100);

            Console.WriteLine(account.Balance);
        }
    }
}