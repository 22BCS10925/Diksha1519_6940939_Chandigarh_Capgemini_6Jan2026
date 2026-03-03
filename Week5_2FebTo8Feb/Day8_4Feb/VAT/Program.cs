namespace VAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Product: ");
            char product=char.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount: ");
            int amount=int.Parse(Console.ReadLine());
            double vatPercent = 0;

            switch (char.ToUpper(product))
            {
                case 'M':
                    vatPercent = 5;
                    break;

                case 'V':
                    vatPercent = 12;
                    break;

                case 'C':
                    vatPercent = 6.25;
                    break;

                default:
                    Console.WriteLine("-1") ; // invalid product
                    break;
            }

            double vatAmount = (amount * vatPercent) / 100;
            Console.WriteLine( vatAmount);
        }
    }
}
