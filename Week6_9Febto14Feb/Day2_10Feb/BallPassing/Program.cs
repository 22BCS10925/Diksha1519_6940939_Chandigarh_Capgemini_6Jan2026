namespace BallPassing
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int N = 4;
            int T = 10;

            int from = (T - 1) % N;
            int to = T % N;

            Console.WriteLine($"Friend {from} passed the ball to Friend {to}");
        }
    }
}
