namespace TotalMarks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the marks of the question for n1 type: ");
                int X = int.Parse(Console.ReadLine());
            Console.Write("Enter the marks of the question for n2 type: ");
            int Y = int.Parse(Console.ReadLine());
            Console.Write("Enter the no. of questions in n1 type");
                int N1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the no. of questions in n2 type");
            int N2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the marks obtained by the student:");
                int M = int.Parse(Console.ReadLine());

                bool found = false;
                int bestA = 0, bestB = 0;

                
                for (int a = N1; a >= 0; a--)
                {
                    int remaining = M - (a * X);
                    if (remaining < 0) continue;

                    if (remaining % Y == 0)
                    {
                        int b = remaining / Y;
                        if (b <= N2)
                        {
                            found = true;
                            bestA = a;
                            bestB = b;
                            break;
                        }
                    }
                }

                if (found)
                {
                    Console.WriteLine("Valid");
                    Console.WriteLine((bestA * X) + " " + (bestB * Y));
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
        }
    }


