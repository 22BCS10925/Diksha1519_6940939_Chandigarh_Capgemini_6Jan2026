namespace Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the marks ");
            int marks = int.Parse(Console.ReadLine());
            if (marks > 90 && marks <= 100)
            {
                Console.WriteLine("Passed with excellent marks A");

            }
            else if (marks > 80 && marks <= 90)
            {
                Console.WriteLine("Passed with good marks : B");
            }
            else if (marks > 70 && marks <= 80)
            {
                Console.WriteLine("Pass :C");
            }
            else if (marks > 60 && marks <= 70)
            {
                Console.WriteLine("ok: D");
            }

            else
            {
                Console.WriteLine("just Passed : E");
            }

        }
    }
}
