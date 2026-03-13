namespace Factorial4
{
    internal class Program
    {
        public int Fact(int output1)
        {
            if (output1 == 0)
            {
                return 1;
            }
            if (output1 < 0)
            {
                return -1;
            }
            if (output1 > 7)
            {
                return -2;

            }
            int ans = 1;
            for (int i = 2; i <= output1; i++)
            {


                ans = ans * i;

            }
            return ans;

        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            int n = int.Parse(Console.ReadLine());
            Console.Write(obj.Fact(n));



        }
    }
}
