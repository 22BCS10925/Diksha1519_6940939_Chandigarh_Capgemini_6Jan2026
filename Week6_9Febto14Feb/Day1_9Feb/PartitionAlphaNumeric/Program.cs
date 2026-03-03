namespace PartitionAlphaNumeric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "a1b2c3";
            string left = "", right = s;

            foreach (char c in s)
            {
                if (char.IsDigit(c))
                    left += c;
            }

            Console.WriteLine("Left: " + left);
            Console.WriteLine("Right: " + right);

        }
    }
}
