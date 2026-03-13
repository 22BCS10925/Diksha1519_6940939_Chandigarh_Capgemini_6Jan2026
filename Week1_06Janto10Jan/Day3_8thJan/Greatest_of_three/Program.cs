using System;
using System.Collections.Generic;
using System.Text;

namespace _5Ques
{
    internal class Greatest_of_three
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Enter first number");
            a = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter second number");
            b = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter third number");
            c = int.Parse(Console.ReadLine()!);

            if (a >= b && a >= c)
            {
                Console.WriteLine(a + "is greatest");
            }
            else if (b >= c && b >= a)
            {
                Console.WriteLine(b + "is greatest");
            }
            else
            {
                Console.WriteLine(c + "is greatest");
            }
        }

    }
}
