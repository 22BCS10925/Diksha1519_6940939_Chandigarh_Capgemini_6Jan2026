namespace CalculatorApp
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine($"Add: {calc.add(4, 7)}");
            Console.WriteLine($"Subtract: {calc.subtract(10, 7)}");
            Console.WriteLine($"Multiply: {calc.multiply(4, 5)}");
            Console.WriteLine($"Divide: {calc.divide(28, 7)}");

        }
    }
}
