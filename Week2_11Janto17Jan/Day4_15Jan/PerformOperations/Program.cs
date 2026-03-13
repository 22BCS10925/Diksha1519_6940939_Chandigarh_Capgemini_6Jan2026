namespace PerformOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            if input3 = 1 find input1+input2
            // Input3 = 2 find input1-input2
            // Input3 = 3 find input1*input2
            //Input3 = 4 find input1/ input2
            //B.R1: if input1 and input2 is less than 0 store - 1 in the output.
            Console.WriteLine("Enter the numbers: ");
            int input1=int.Parse(Console.ReadLine());
            int input2=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the operation you want to perform but it is int the int format");
            int input3 = int.Parse(Console.ReadLine());
            if (input1 < 0 && input2 < 0)
            {
                input3 = -1;
            }
            switch (input3)
            {
                case 1:
                    input3 = input1 + input2;
                    Console.WriteLine(input3);
                    break;
                case 2:
                    input3 = input1 - input2;
                    Console.WriteLine(input3);
                    break;
                case 3:
                    input3 = input1 * input2;
                    Console.WriteLine(input3);
                    break;
                case 4:
                    input3 = input1 / input2;
                    Console.WriteLine(input3);
                    break;
                default:
                    Console.WriteLine("-2");
                    break;
            }

        }
    }
}
