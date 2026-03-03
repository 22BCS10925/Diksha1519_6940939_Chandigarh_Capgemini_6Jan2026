namespace ConsoleAppCU
{
    internal class Program
    {
        //int x, y;
        //Console.WriteLine("enter the value of x: ");
        //x=int .Parse(Console.ReadLine());
        //Console.WriteLine("enter the value of y: ");
        //y= int.Parse(Console.ReadLine());
        //if (x > y)
        //{
        //    Console.WriteLine("X is greater than y ");

        //}
        //else
        //{
        //    Console.WriteLine("y is greater than x");
        //}

        //int[] arr = new int[3];
        //arr[0] = 1; 
        //arr[1] = 2;
        //arr[2] = 30;
        //for(int i = 0; i < 3; i++)
        //{
        //    Console.WriteLine(arr[i]);
        //}

        //foreach(int x in arr)
        //{
        //    Console.WriteLine(x);
        //}
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the value for x");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value for y");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value for z");
            int z = int.Parse(Console.ReadLine());
            if (x > y)
            {
                Console.WriteLine("x is greater than y");
                if (x > z)
                {
                    Console.WriteLine("xis greater than z");
                }
                else
                {
                    Console.WriteLine("z is greater");
                }
                if (y > z)
                {
                    Console.WriteLine("y is greater");
                }
                else
                {
                    Console.WriteLine("z i greater");
                }

               
            }
            else
            {
                Console.WriteLine("x is greater");
            }


        }


    }

}
