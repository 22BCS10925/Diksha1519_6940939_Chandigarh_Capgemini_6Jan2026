using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

public interface IBankAccountOperation
{
    /* 
        Sample operations expected to be proceeded 
        Values may be different 
        -I want to see my balance 
        -I want to see money in my account 
        -I want to withdraw 200 
        -I want to pull 100 
        -I want to deposit 500 
        -I want to invest 600 
        -I want to transfer 100 to my account 
        -I want to deposit 500 dollars 
        -Pull 100 dollars 
        -Deposit 200 
    */
    void Deposit(decimal d);
    void Withdraw(decimal d);
    //returns the current balance after process. 
    decimal ProcessOperation(string message);
}

//Create BankOperations class by implementing IBankAccountOperation interface
class BankOperations : IBankAccountOperation  
{
    private decimal balance = 0;
    public void Deposit(decimal d)
    {
        balance += d;

    }
    public void Withdraw(decimal d)
    {
        if(balance >= d )
        {
            balance -= d;
        }

    }
    //returns the current balance after process. 
    public decimal ProcessOperation(string message)
    {
        if (string.IsNullOrWhiteSpace(message))
        {
            return balance;
        }
        string lowerMessage=message.ToLower();
        decimal amount = 0;
        Match m = Regex.Match(lowerMessage,@"\d+");
        if (m.Success)
        {
            amount = Convert.ToDecimal(m.Value);
        }
        if(message.Contains("Deposit")|| message.Contains("push")|| message.Contains("transfer"))
        {
            Deposit(amount);
        }
        else if (message.Contains("Withdraw") || message.Contains("pull") )
        {
            Withdraw(amount);
        }
        else if(message.Contains("see") || message.Contains("balance"))
        {
            return balance;
        }

        return amount;
    }


}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string k = Console.ReadLine();
        int n = Convert.ToInt32(k);
        List<string> inputs = new List<string>();
        for (int i = 0; i < n; i++)
        {
            inputs.Add(Console.ReadLine());
        }
        BankOperations opt = new BankOperations();
        foreach (var item in inputs)
        {
            textWriter.WriteLine(opt.ProcessOperation(item));
        }

        textWriter.Flush();
        textWriter.Close();
    }
}




