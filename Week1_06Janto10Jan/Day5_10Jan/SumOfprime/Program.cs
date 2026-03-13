namespace Sumofprime;


internal class Program
{
    static void Main()
    {
        int[] input1 = { 1, 2, 3, 4, 5 };
        int input2 = 5;   
        int output1 = 0;

       
        if (input2 < 0)
        {
            output1 = -2;
        }
        else
        {
            bool hasPrime = false;

            for (int i = 0; i < input2; i++)
            {
              
                if (input1[i] < 0)
                {
                    output1 = -1;
                    Console.WriteLine(output1);
                    return;
                }

               
                int num = input1[i];
                int count = 0;

                for (int j = 1; j <= num; j++)
                {
                    if (num % j == 0)
                        count++;
                }

                if (count == 2) // prime
                {
                    hasPrime = true;
                    output1 += num;
                }
            }

           
            if (!hasPrime)
                output1 = -3;
        }

        Console.WriteLine(output1);
    }
}

