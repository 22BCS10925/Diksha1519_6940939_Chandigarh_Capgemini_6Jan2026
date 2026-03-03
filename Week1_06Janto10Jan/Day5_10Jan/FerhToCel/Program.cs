namespace FerhToCel
{
  
  internal  class Program
    {
        static void Main()
        {
            double fahrenheit = 50; 
            double celsius;

            if (fahrenheit < 0)
            {
                celsius = -1;
            }
            else
            {
                celsius = (5.0 / 9) * (fahrenheit - 32);
            }

            Console.WriteLine(celsius);
        }
    }

}
