using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> ticketQueue = new Queue<string>();
        ticketQueue.Enqueue("Ticket 101");
        ticketQueue.Enqueue("Ticket 102");
        ticketQueue.Enqueue("Ticket 103");

        Console.WriteLine("\nIncoming tickets : ");
        foreach (var t in ticketQueue)
        {
            Console.WriteLine(t);
        }

        Stack<string> actionStack = new Stack<string>();

        string currentTicket = ticketQueue.Dequeue();

        Console.WriteLine("\nProcessing: " + currentTicket);
        actionStack.Push("Checked customer details");
        actionStack.Push("Updated Customer Tickets");
        actionStack.Push("Sent response on emails");

        Console.WriteLine("\nAction Processed: ");
        foreach (var a in actionStack)
        {
            Console.WriteLine(a);
        }

        string undolastaction = actionStack.Pop();
        Console.WriteLine("\nUndo the Last Action: " + undolastaction);

        Console.WriteLine("\nRemaining Action: ");
        foreach (var item in actionStack)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\nRemaining Tickets: ");
        foreach (var t in ticketQueue)
        {
            Console.WriteLine(t);
        }
    }
}