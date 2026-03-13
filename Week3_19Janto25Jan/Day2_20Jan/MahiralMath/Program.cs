using System;

namespace MahiralMath
{
    internal class Program
    {
        static int target;
        static int[] best; 

        public void FindMin(int current, int steps)
        {
            
            if (current < 0 || current > target * 3)
                return;

           
            if (best[current] <= steps)
                return;

            
            best[current] = steps;

          
            FindMin(current + 2, steps + 1);
            FindMin(current - 1, steps + 1);
            FindMin(current * 3, steps + 1);
        }

        static void Main()
        {
            Console.Write("Enter Target N: ");
            target = int.Parse(Console.ReadLine());

            best = new int[target * 3 + 1];

           
            for (int i = 0; i < best.Length; i++)
                best[i] = int.MaxValue;

            Program obj = new Program();
            obj.FindMin(10, 0);

            Console.WriteLine("Minimum operations = " + best[target]);
        }
    }
}
