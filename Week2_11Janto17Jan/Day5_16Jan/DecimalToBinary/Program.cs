namespace DecimalToBinary;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the decimal number:");
        int input1 = int.Parse(Console.ReadLine());

        int[] output;

        if (input1 < 0)
        {
            output = new int[] { -1 };
        }
        else if (input1 == 0)
        {
            output = new int[] { 0 };
        }
        else
        {
            
            int[] temp = new int[32];
            int index = 0;

            while (input1 > 0)
            {
                temp[index] = input1 % 2;
                input1 /= 2;
                index++;
            }

           
            output = new int[index];
            int j = 0;
            for (int i = index - 1; i >= 0; i--)
            {
                output[j++] = temp[i];
            }
        }

      
        Console.WriteLine("Output:");
        foreach (int i in output)
        {
            Console.Write(i + " ");
        }
    }
}
