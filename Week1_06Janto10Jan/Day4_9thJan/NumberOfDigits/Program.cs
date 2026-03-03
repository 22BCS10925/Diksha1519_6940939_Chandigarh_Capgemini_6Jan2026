namespace NumberOfDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int digit = 0;
           
            Console.WriteLine("Enter the Number: ");
            int num = int.Parse(Console.ReadLine());
            int temp = (int)num;
            if (num < 0)
            {
                temp = -1;
                
            }
            while(temp > 0)
            {
                digit++;
                temp /=10;

            }
            Console.WriteLine(digit);
        }
    }
}
