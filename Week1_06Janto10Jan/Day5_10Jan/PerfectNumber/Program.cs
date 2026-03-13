namespace PerfectNumber
{

    internal class Program
    {
        static void Main()
        {
            int num = 28; 
            int output;

            if (num < 0)
            {
                output = -2;
            }
            else
            {
                int sum = 0;
                for (int i = 1; i < num; i++)
                {
                    if (num % i == 0)
                        sum += i;
                }

                if (sum == num)
                    output = 1;
                else
                    output = -1;
            }

            Console.WriteLine(output);
        }
    }

}
