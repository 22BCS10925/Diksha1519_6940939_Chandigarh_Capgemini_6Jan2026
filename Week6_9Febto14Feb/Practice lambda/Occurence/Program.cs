using System;

namespace Occurence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>() { 1, 2, 2, 3, 3, 3, 4, 5, 5, 5, 5 };
            //Dictionary<int, int> dic = new Dictionary<int, int>();

            ////int count = 0;
            //foreach (int i in list)
            //{
            //    if (dic.ContainsKey(i))
            //    {
            //        dic[i]++;
            //    }
            //    else
            //    {
            //        dic[i] = 1;
            //    }
            //}
            //foreach (var i in dic)
            //{
            //    Console.WriteLine(i.Key + " Occurence will be: " + i.Value);

            //}

            //COUNT NUMBER OF DIGITS
            //List<int> li = new List<int> { 1, 2, 3, 3, 4, 1, 4, 5, 1, 2 };

            //Dictionary<int, int> dict = new Dictionary<int, int>();

            //foreach (int i in li)
            //{
            //    if (dict.ContainsKey(i))
            //    {
            //        dict[i]++;
            //    }
            //    else
            //    {
            //        dict[i] = 1;
            //    }
            //}
            //foreach (var i in dict)
            //{
            //    Console.WriteLine($"{i.Key} occurs {i.Value} times");
            //}


            //NUMBER OF TYRES IN EACH DEALERSHIP
            //Console.WriteLine("Enter Number of Dealerships: ");
            //int n = int.Parse(Console.ReadLine());
            //List<int> ans = new List<int>();

            //for(int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"Number of Cars Dealer {i+1} contains: ");
            //    string[] inpt = Console.ReadLine().Split();
            //    int car = int.Parse(inpt[0]);
            //    int bikes = int.Parse(inpt[1]);
            //    int sum = (car * 4) + (bikes * 2);

            //    ans.Add(sum);
            //}
            //int a = 0;
            //foreach (int x in ans)
            //{
            //    Console.WriteLine($"Total Number of tyres in dealership{a+1} is {x}");
            //    a++;
            //}


            //FACTORS OF A NUMBER

            //Console.WriteLine("Enter the number: ");
            //int nums = int.Parse(Console.ReadLine());
            //List<int> ans = new List<int>();

            //for(int i = 1; i < nums; i++)
            //{
            //    if (nums%i == 0)
            //    {
            //        ans.Add(i);
            //    }
            //}
            //foreach(int i in ans)
            //{
            //    Console.WriteLine(i);
            //}


            //MAXIMUM MARKS IN EACH SEMESTER

            //Console.WriteLine("Enter number of semester: ");
            //int sem = int.Parse(Console.ReadLine());
            //// List<int> sub = new List<int>();
            //int[] sub = new int[sem];
            //for(int i = 0; i < sem; i++)
            //{
            //    Console.WriteLine($"Enter the subjects in {i + 1} semster : ");
            //    sub[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < sem; i++)
            //{
            //    Console.WriteLine($"Enter Marks of {i + 1} semester: ");
            //    string[] marksStr = Console.ReadLine().Split();

            //    int maxi = int.MinValue;
            //    for (int j =  0; j < marksStr.Length; j++)
            //    {
            //        int marks = int.Parse(marksStr[j]);

            //        if(marks < 0 || marks > 100)
            //        {
            //            Console.WriteLine("You have entered invalid mark.");
            //            return;
            //        }
            //        if(marks > maxi)
            //        {
            //            maxi = marks;
            //        }
            //    }
            //    Console.WriteLine($"Maximum mark in {i + 1} semester:{maxi}");
            //}


            //MINIMUM DISCOUNT PRICE

            //Console.WriteLine("Enter the Number of Items: ");
            //int items  = int.Parse(Console.ReadLine());

            //Console.WriteLine("Product details--");
            //string ans = null;
            //int mini = int.MaxValue;
            //for(int i = 0; i < items; i++)
            //{
            //    Console.WriteLine($"Product {i + 1} details: ");
            //    string[] prod = Console.ReadLine().Split(",");

            //    int price = int.Parse(prod[1]);
            //    int discount = int.Parse(prod[2]);

            //    int discountP = (price * discount) / 100;
            //    if(discountP < mini)
            //    {
            //        mini = discountP;
            //        ans = prod[0];
            //    }
            //}
            //Console.WriteLine($"Minimum discount for product {ans} is {mini} ");


            // //MOVE Hash

            //Console.WriteLine("Enter the input: ");
            //string input=Console.ReadLine();

            //string hash = "";
            //string other = "";
            //foreach(var s in input)
            //{
            //    if(s == '#')
            //    {
            //        hash += s;
            //    }
            //    else
            //    {
            //        other += s;
            //    }

            //}
            //Console.WriteLine(hash+other);


            //VALLEY 
            //Console.WriteLine("Enter size: ");
            //int n = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Sequence of up and down: ");
            //string path = Console.ReadLine();
            //int level = 0;
            //int valleys = 0;

            //foreach (char c in path)
            //{
            //    if (c == 'U')
            //    {
            //        level++;
            //        if (level == 0)
            //        {
            //            valleys++;
            //        }
            //    }
            //    else
            //    {
            //        level--;
            //    }
            //}
            //Console.WriteLine("Count of Valleys: " + valleys);


            //Identical Matrices  Or Not

            //    int[,] A =
            //    {
            //    {1,1,1,1},
            //    {2,2,2,2},
            //    {3,3,3,3},
            //    {4,4,4,4}
            //};

            //    int[,] B =
            //    {
            //    {1,1,1,1},
            //    {2,2,2,2},
            //    {3,3,5,3},
            //    {4,4,4,4}
            //};

            //    bool identical = true;

            //    int rows = A.GetLength(0);
            //    int cols = A.GetLength(1);

            //    for (int i = 0; i < rows; i++)
            //    {
            //        for (int j = 0; j < cols; j++)
            //        {
            //            if (A[i, j] != B[i, j])
            //            {
            //                identical = false;
            //                break;
            //            }
            //        }
            //        if (!identical)
            //            break;
            //    }

            //    if (identical)
            //        Console.WriteLine("Matrices are identical");
            //    else
            //        Console.WriteLine("Matrices are not identical");


            //  STRING ROTATION
            //Console.WriteLine("Enter the string input1: ");
            //string input1 = Console.ReadLine();

            //Console.WriteLine("Enter the string input2: ");
            //string input2=Console.ReadLine();


            //if (StringRotate.CheckRotate(input1, input2))
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}


            //Missing nUmber

            int[] arr = { 1, 2, 4, 5, 6 };
            int n = arr.Length + 1;

            int expectedSum = n * (n + 1) / 2;
            int actualSum = 0;

            foreach (int num in arr)
            {
                actualSum += num;
            }

            int missing = expectedSum - actualSum;
            Console.WriteLine("Missing number: " + missing);
        }
    }


}

