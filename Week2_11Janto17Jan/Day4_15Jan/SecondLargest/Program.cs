namespace SecondLargest;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the size: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        if (n < 0)
        {
            Console.WriteLine("-2");
        }

        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());


            if (arr[i] < 0)
            {
                Console.WriteLine("-1");
                return;
            }
        }



        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        foreach (int num in arr)
        {
            if (num > largest)
            {
                secondLargest = largest;
                largest = num;
            }
            else if (num > secondLargest && num != largest)
            {
                secondLargest = num;
            }
        }

        Console.WriteLine("Second Largest = " + secondLargest);
    }
}
