namespace DivisibleBy5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the limit: ");
            int n = int.Parse(Console.ReadLine());
            int count=0;
            int sum = 0;

            if (n < 0)
            {
                Console.WriteLine("-1");
            }
            
            for(int i = 0; i < n; i++)
            {
                
                if (i % 5 == 0)
                {
                    sum += i;
                    count++;
                    Console.WriteLine("Number Divisible by 5 are: " + i);
                }

            }
            int avg = sum / count;
            Console.WriteLine("Average of the number: " + avg);
        }
    }
}
