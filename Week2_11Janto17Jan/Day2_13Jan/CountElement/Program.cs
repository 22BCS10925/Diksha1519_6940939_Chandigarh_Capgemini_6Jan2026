namespace CountElement;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the size of an array: ");
        int n = int.Parse(Console.ReadLine());
        int[] input1 = new int[n];
       // int input2 = 5;
   
        int output;
        Console.WriteLine("Enter the Elements: ");
        for(int i = 0; i < n; i++)
        {
            input1[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter the element you want to search: ");
        int input3 = int.Parse(Console.ReadLine());
        // BR-2: If array size is negative
        if (n < 0)
        {
            output = -2;
        }
        // BR-3: If search value is negative
        else if (input3 < 0)
        {
            output = -3;
        }
        else
        {
            // BR-1: If any array value is negative
            bool hasNegative = false;
            for (int i = 0; i < n; i++)
            {
                if (input1[i] < 0)
                {
                    hasNegative = true;
                    break;
                }
            }

            if (hasNegative)
            {
                output = -1;
            }
            else
            {
                
                int count = 0;
                for (int i = 0; i < n; i++)
                {
                    if (input1[i] == input3)
                        count++;
                }
                output = count;
            }
        }

        Console.WriteLine("Output = " + output);
    }
}
