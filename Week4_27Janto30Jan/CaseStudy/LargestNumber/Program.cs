using System;
using LargestNumber;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the size: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.Write("Enter the elements in an array: ");
        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(Console.ReadLine());
        Console.WriteLine("Largest sum will be :");
        Console.WriteLine(Largest.largestNumber(arr));
    }
}
