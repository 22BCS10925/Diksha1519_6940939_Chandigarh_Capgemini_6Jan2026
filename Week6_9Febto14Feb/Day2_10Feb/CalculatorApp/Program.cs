namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculators cal = new Calculators();
            int res1 = cal.Substract(3, 4);
            Console.WriteLine("Subtract: " + res1);
            int res2 = cal.Add(5, 6);
            Console.WriteLine("Add: " + res2);
            int res3 = cal.Multiply(3, 6);
            Console.WriteLine("Multiply: " + res3);
            double res4 = cal.Divide(3, 6);
            Console.WriteLine("Divide: " + res4);
        }
    }
}
