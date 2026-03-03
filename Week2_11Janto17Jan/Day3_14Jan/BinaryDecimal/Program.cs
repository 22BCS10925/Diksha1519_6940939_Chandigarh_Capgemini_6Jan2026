namespace BinaryDecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Binary Number: ");
            int n=int.Parse(Console.ReadLine());
            int output = 0;
            int power = 1;
            int digit = 0;

            if (n < 0) 
            {
                output = -1;

            }
            if (n > 1111)
            {
                output = -2;
            }
           
            while (n > 0)
            {
                digit = n % 10;

              
                if (digit != 0 && digit != 1)
                {
                    output = -1;
                    return;
                }

                output += digit * power;
                power *= 2;
                n /= 10;


            }
            Console.WriteLine(output);
        }
    }
}
