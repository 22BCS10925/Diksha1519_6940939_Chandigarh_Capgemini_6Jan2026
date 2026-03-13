using System;
using System.Linq;
using System.Collections.Generic;

public class Books
{
    public string BookName;
    public int price;
    public string stock;

    public Books(string bookName, int price, string stock)
    {
        BookName = bookName;
        this.price = price;
        this.stock = stock;
    }

    static void Main(string[] args)
    {
        List<Books> b = new List<Books>();

        // Properly adding books to list
        b.Add(new Books("C/C++", 180, "Available"));
        b.Add(new Books("Python", 200, "Unavailable"));
        b.Add(new Books("DemoDogs", 300, "Available"));
        b.Add(new Books("Angels", 450, "Unavailable"));
        b.Add(new Books("Fairies", 430, "Available"));

        double targetValue = 400;
        Console.WriteLine("Finding Books which are cheaper than 400");

        var target =
            from x in b
            where x.price < targetValue
            select x;

       // Console.WriteLine(target);
        foreach (var book in target)
        {
            Console.WriteLine(book.BookName + " - " + book.price + " - " + book.stock);
        }
        var upper = b.Where(x => x.stock == "Unavailable");
        foreach (var book in upper)
        {
            Console.WriteLine("Books are: " + book.BookName);
        }
    }
}
