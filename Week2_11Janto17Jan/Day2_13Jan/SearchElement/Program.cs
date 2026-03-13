namespace SearchElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of an array: ");
            int n=int.Parse(Console.ReadLine());
            int[] arr=new int[n];
            int output = 0;
            Console.WriteLine("Enter the elements in an array: ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the element you want to search: ");
            int search=int.Parse(Console.ReadLine());
            if (n < 0)
            {
                output = -2;
            }
        
            for(int i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    output = -1;
                }
                if (arr[i] == search)
                {
                    output = 1;
                    break;
                }
                else
                {
                    //Console.WriteLine("Element Not Found: ");
                    output = -3;
                }

            }
            Console.WriteLine("Element Found: "+output);

        }
    }
}
