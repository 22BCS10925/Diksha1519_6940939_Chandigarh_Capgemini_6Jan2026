namespace DonationLocation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size: ");
            int n=int.Parse(Console.ReadLine());

            string[] str=new string[n];
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = Console.ReadLine();
            }
            Console.WriteLine("Enter the location: ");
            int input2=int.Parse(Console.ReadLine());
            Console.WriteLine("Sum: " + UserProgamCode.getDonation(str, input2));
        }
    }
}
