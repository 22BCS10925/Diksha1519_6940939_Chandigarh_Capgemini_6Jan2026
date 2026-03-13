namespace Replace
{

 
   internal class Program
    {
        static void Main()
        {
            int[] input1 = { 12, 34, 56, 17, 2 };
            int input2 = 5;
            int[] output1 = new int[input2];

           
            if (input2 < 0)
            {
                output1 = new int[1];
                output1[0] = -2;
                Console.WriteLine(output1[0]);
                return;
            }

          
            for (int i = 0; i < input2; i++)
                output1[i] = input1[i];

        
            for (int i = 0; i < input2; i++)
            {
                if (input1[i] < 0)
                {
                    output1[0] = -1;
                    Console.WriteLine(output1[0]);
                    return;
                }
            }

        
            int left = 0;
            int right = input2 - 1;

            while (left < right)
            {
                int temp = output1[left];
                output1[left] = output1[right];
                output1[right] = temp;

                left++;
                right--;
            }

          
            for (int i = 0; i < output1.Length; i++)
                Console.Write(output1[i] + " ");
        }
    }

}
