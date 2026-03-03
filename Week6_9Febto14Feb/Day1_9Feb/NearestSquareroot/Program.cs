namespace NearestSquareroot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the digit: ");
            int num=int.Parse(Console.ReadLine());

            double root=Math.Sqrt(num);
            Console.WriteLine("Root value: " + root);

            int lower = (int)Math.Floor(root);
            int upper = lower + 1;

            Console.WriteLine("lower Value: " + lower);
            Console.WriteLine("Upper Value: "+upper);

            lower = lower * lower;
            upper = upper * upper;
            int res = 0;

            if(num-lower < upper - num)
            {
                res = lower;

            }
            else
            {
                res = upper;
            }
            Console.WriteLine("Nearest Value: " + res);
        }
    }
}
