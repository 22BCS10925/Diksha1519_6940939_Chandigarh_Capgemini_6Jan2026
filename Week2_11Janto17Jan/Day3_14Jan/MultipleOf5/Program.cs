namespace MultipleOf5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int n=int.Parse(Console.ReadLine());
            int sum = 0;
            int avg = 0;
            int count = 0;

            if (n < 0)
            {
                Console.WriteLine("-1");
            }
            if (n > 500)
            {
                Console.WriteLine("-2");
            }
            int i = 1;
            while (i <= n)
            {
                if (i % 5 == 0)
                {
                    sum += i;
                    count++;
                   
                }
                i++;
            }
            avg=sum / count;
            Console.WriteLine("Avg will be: "+avg);
        }
    }
}
