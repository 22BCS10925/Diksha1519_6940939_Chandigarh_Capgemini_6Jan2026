using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCU
{
    internal class Practice1
    {
        public static void main(string[] args)
        {
            Console.WriteLine("Enter the value for x");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value for y");
            int y=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value for z");
            int z = int.Parse(Console.ReadLine());
            if (x > y)
            {
                Console.WriteLine("x is greater than y");
                if (x>z)
                {
                    Console.WriteLine("xis greater than z");
                }
                else
                {
                    Console.WriteLine("z is greater");
                }
            if (y > x)
                {
                    Console.WriteLine("y is greater");
                }
                else
                {
                    Console.WriteLine("z i greater");
                }
                Console.WriteLine("zis greater");
            }

      

        }
    }
}
