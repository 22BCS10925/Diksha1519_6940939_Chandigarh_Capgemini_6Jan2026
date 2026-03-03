using System;
using System.Collections.Generic;
using System.Text;

namespace Quizz
{
    internal class third
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("lets play a quizz");
            Console.Write("1:");
            Console.WriteLine("int 1x=10");
            Console.Write("2: ");
            Console.WriteLine("int x=10");
            Console.Write("3: ");
            Console.WriteLine("float x=10.0f;");
            Console.Write("4: ");
            Console.WriteLine("string x=*10*");

            Console.WriteLine("Choose the correct options");
            int x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:
                    Console.WriteLine("Choose wrong try again");
                    break;
                case 2:
                    Console.WriteLine("Try Again");
                    break;
                case 3:
                    Console.WriteLine("Right YOU WIN");
                    break;
                default:
                    Console.WriteLine("Better Luck Next Time:");
                    break;

            }

        }
    }
}
