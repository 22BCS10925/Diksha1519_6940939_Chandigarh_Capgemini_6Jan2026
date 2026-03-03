using System;
using System.Collections.Generic;

namespace ListTheElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size: ");
            int n = int.Parse(Console.ReadLine());

            List<int> li = new List<int>();
            for (int i = 0; i < n; i++)
            {
                li.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Enter the input2: ");
            int input2 = int.Parse(Console.ReadLine());

            List<int> resultList = List.GetElements(li, n, input2);

            Console.Write("Resulted List: ");
            foreach (int x in resultList)
            {
                Console.Write(x + " ");
            }
        }
    }
}
