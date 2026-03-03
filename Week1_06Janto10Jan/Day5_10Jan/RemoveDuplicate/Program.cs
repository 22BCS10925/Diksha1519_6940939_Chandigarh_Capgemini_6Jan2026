namespace RemoveDuplicate
{
  
   internal class Program
    {
        static void Main()
        {
            int[] input1 = { 1, 2, 2, 3, 3 };
            int input2 = 5;

           
            if (input2 < 0)
            {
                Console.WriteLine(-2);
                return;
            }

           
            for (int i = 0; i < input2; i++)
            {
                if (input1[i] < 0)
                {
                    Console.WriteLine(-1);
                    return;
                }
            }

            
            int[] output = new int[input2];
            int count = 0;

            for (int i = 0; i < input2; i++)
            {
                bool exists = false;
                for (int j = 0; j < count; j++)
                {
                    if (output[j] == input1[i])
                    {
                        exists = true;
                        break;
                    }
                }

                if (!exists)
                {
                    output[count] = input1[i];
                    count++;
                }
            }

           
            for (int i = 0; i < count; i++)
                Console.Write(output[i] + " ");
        }
    }

}
