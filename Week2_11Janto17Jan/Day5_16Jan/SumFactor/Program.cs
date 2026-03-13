namespace SumOfFactor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter input1:");
            int input1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter input2:");
            int input2 = int.Parse(Console.ReadLine());

            int output = 0;

            // Business Rules
            if (input1 < 0)
            {
                output = -1;
            }
            else if (input2 > 32627)
            {
                output = -2;
            }
            else
            {
                for (int i = input1; i <= input2; i += input1)
                {
                    output += i;
                }
            }

            Console.WriteLine("Output = " + output);
        }
    }
}
