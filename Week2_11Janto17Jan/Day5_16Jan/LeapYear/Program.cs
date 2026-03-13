namespace LeapYear;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a year:");
        int year = int.Parse(Console.ReadLine());

        int output;

        if (year < 0)
        {
            output = -1;
        }
        else
        {
            bool isLeap;

            
            if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                isLeap = true;
            else
                isLeap = false;

          
            if (isLeap)
                output = 1;
            else
                output = -2;
        }

        Console.WriteLine("Output: " + output);
    }
}
