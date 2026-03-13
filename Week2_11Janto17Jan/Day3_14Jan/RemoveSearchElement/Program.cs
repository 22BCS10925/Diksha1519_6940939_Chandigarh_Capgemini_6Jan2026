using System;

namespace RemoveSearchElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size:");
            int input2 = int.Parse(Console.ReadLine());

            
            if (input2 < 0)
            {
                Console.WriteLine("-2");
                return;
            }

            int[] input1 = new int[input2];
            int[] output = new int[input2];
            int outIndex = 0;

            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < input2; i++)
            {
                input1[i] = int.Parse(Console.ReadLine());

              
                if (input1[i] < 0)
                {
                    Console.WriteLine("-1");
                    return;
                }
            }

            Console.WriteLine("Enter search element:");
            int input3 = int.Parse(Console.ReadLine());

            bool found = false;

           
            for (int i = 0; i < input2; i++)
            {
                if (input1[i] == input3)
                {
                    found = true;
                    continue;
                }
                output[outIndex++] = input1[i];
            }

         
            if (!found)
            {
                Console.WriteLine("-3");
                return;
            }

            
            Console.WriteLine("Output Array:");
            for (int i = 0; i < outIndex; i++)
            {
                Console.WriteLine(output[i]);
            }
        }
    }
}
