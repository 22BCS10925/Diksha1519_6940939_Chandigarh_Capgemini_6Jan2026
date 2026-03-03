using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Button
{
    internal class _2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Press the Button from 0 to 9");
            string b = Console.ReadLine();

            switch (b)
            {
                case "0":
                    Console.WriteLine("0");
                    break;
                case "1":
                    Console.WriteLine("1");
                    break;
                case "2":
                    Console.WriteLine("2");
                    break;
                case "3":
                    Console.WriteLine("3");
                    break;
                case "4":
                    Console.WriteLine("4");
                    break;
                case "5":
                    Console.WriteLine("5");
                    break;
                case "6":
                    Console.WriteLine("6");
                    break;
                case "7":
                    Console.WriteLine("7");
                    break;
                case "8":
                    Console.WriteLine("8");
                    break;
                case "9":
                    Console.WriteLine("9");
                    break;
                default:
                    Console.WriteLine("please enter number from 0 to 9 only");
                    break;
            }
        }
    }
}
