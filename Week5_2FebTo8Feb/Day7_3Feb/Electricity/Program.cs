using System.Text.RegularExpressions;

namespace Electricity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the input");
            string input1=Console.ReadLine();

            Console.WriteLine("Enter the input");
            string input2 = Console.ReadLine();

            string input3 = @"\d+";
            MatchCollection match=Regex.Matches(input1, input3);
            MatchCollection match2 = Regex.Matches(input2, input3);
            string res;
            string res2;
            int val1 = 0;
            int val2 = 0;
            foreach (Match m in match)
            {
                res = m.Value;
                Console.WriteLine("value:" + res);
               val1 = int.Parse(res);
            }
            foreach(Match m in match2)
            {
                res2=m.Value;
                Console.WriteLine("value2: " + res2);
                val2 = int.Parse(res2);
            }
            Console.WriteLine("Enter the multiple value for bill");
            int bill=int.Parse(Console.ReadLine());

            int diff = val2-val1;
            int Amount = bill * diff;
            Console.WriteLine("Amount: " + Amount);

        }
    }
}
