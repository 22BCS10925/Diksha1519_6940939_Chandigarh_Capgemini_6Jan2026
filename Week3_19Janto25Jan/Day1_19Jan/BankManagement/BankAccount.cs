using System;
using System.Collections.Generic;
using System.Text;

namespace BankManagement
{
    public abstract class BankAccount
    {
        public string HolderName;
        public int ID;
        protected double amountHold;

       
        protected int depositCount = 0;
        protected int withdrawCount = 0;

        public BankAccount()
        {
            Console.Write("Enter Account Holder Name: ");
            HolderName = Console.ReadLine();

            Console.Write("Enter ID: ");
            ID = int.Parse(Console.ReadLine());

            Console.Write("Enter Initial Balance: ");
            amountHold = double.Parse(Console.ReadLine());
        }

        public double Deposit(double amount)
        {
            if (amount > 0)
            {
                amountHold += amount;
                depositCount++;   
            }
            return amountHold;
        }

        public double Withdraw(double amount)
        {
            if (amount > 0 && amount <= amountHold)
            {
                amountHold -= amount;
                withdrawCount++;  
            }
            return amountHold;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("\n--- Account Details ---");
            Console.WriteLine("Account No   : " + ID);
            Console.WriteLine("Holder Name : " + HolderName);
            Console.WriteLine("Balance     : " + amountHold);
        }

        public abstract void TransactionDetails();
    }
public class SavingAccount : BankAccount
    {
        public double InterestRate;

        public SavingAccount() : base()
        {
            Console.Write("Enter Interest Rate (%): ");
            InterestRate = double.Parse(Console.ReadLine());
        }

        public void InterestValue()
        {
            double interest = (amountHold * InterestRate) / 100;
            amountHold += interest;
        }

        public override void TransactionDetails()
        {
            Console.WriteLine("\n--- Saving Account Transactions ---");
            Console.WriteLine("Interest Rate : " + InterestRate + "%");
            Console.WriteLine("Final Balance: " + amountHold);
        }
    }
    public class CheckAccount : BankAccount
    {
        public double TransactionFee;

        public CheckAccount() : base()
        {
            Console.Write("Enter Transaction Fee: ");
            TransactionFee = double.Parse(Console.ReadLine());
        }

        public void DeductFee()
        {
            amountHold -= TransactionFee;
        }

       
        public override void TransactionDetails()
        {
            Console.WriteLine("\n--- Check Account Transactions ---");
            Console.WriteLine("Total Deposits   : " + depositCount);
            Console.WriteLine("Total Withdraws : " + withdrawCount);
            Console.WriteLine("Transaction Fee : " + TransactionFee);
            Console.WriteLine("Final Balance   : " + amountHold);
        }
    }


}
