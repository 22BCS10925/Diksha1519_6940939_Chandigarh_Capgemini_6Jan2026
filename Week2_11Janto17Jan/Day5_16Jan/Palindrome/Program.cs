
namespace Palindrome
{
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter a number:");
                int input = int.Parse(Console.ReadLine());

                int output;

               
                if (input < 0)
                {
                    output = -1;
                }
                else
                {
                    int original = input;
                    int reverse = 0;
                    int digit;

                    while (input > 0)
                    {
                        digit = input % 10;
                        reverse = (reverse * 10) + digit;
                        input = input / 10;
                    }

                   
                    if (original == reverse)
                        output = 1;
                    else
                        output = -2;
                }

                Console.WriteLine("Output: " + output);
            }
        }
    }


