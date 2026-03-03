namespace CubeOfNumber
{
  
  internal  class Program
    {
        static void Main()
        {
            int n = 5; 
            int output = 0;

            if (n < 0 || n > 7)
            {
                output = -1;
            }
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    if (IsPrime(i))
                        output += i * i * i;
                }
            }

            Console.WriteLine(output);
        }

        static bool IsPrime(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }

}
