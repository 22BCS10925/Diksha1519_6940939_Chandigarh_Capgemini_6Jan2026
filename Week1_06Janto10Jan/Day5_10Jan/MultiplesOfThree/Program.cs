namespace MultiplesOfThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of an array");
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            int count = 0;
            if (n < 0)
            {
                count = -2;
            }
            for(int i = 0; i < n; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < n; i++)
            {
                if (arr1[i] < 0)
                {
                    count = -1;
                }
                if (arr1[i] % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Multiple of three in an array is: "+count);   
        }
    }
}
