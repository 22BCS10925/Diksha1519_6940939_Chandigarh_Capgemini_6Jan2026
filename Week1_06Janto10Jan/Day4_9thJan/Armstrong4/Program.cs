
namespace Armstrong4
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter the number: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num < 0)
                {
                    Console.WriteLine("Invalid input: negative number");
                    return;
                }

                if (num > 999)
                {
                    Console.WriteLine("Only up to 3-digit numbers allowed");
                    return;
                }

                int temp = num;
                int sum = 0;
                int digit = 0;

                // Count digits
                while (temp > 0)
                {
                    digit++;
                    temp /= 10;
                }

                temp = num;

                // Armstrong calculation
                while (temp > 0)
                {
                    int rem = temp % 10;
                    sum += (int)Math.Pow(rem, digit);
                    temp /= 10;
                }

                if (sum == num)
                {
                
                    Console.WriteLine("Armstrong Number");
                }
                else
                {
                    Console.WriteLine("Not an Armstrong Number");
                }
            }
        }
    
}