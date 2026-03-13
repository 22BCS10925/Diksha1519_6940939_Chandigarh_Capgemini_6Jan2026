using System;
using System.Collections.Generic;

namespace Class_member
{
    public class Students
    {
        public enum StudentYear
        {
            FirstYear,
            SecondYear,
            ThirdYear,
            FourthYear
        }

        public struct Address
        {
            public string City;
            public string State;

            public Address(string city, string state)
            {
                City = city;
                State = state;
            }

            public void ShowAddress()
            {
                Console.WriteLine($"Address: {City}, {State}");
            }
        }

        static int count;
        public const string Dept = "CSE";
        public readonly int StudentID;
        string studentName;
        double fee;

        public StudentYear Year;
        public Address Addr;

        // Static Constructor
        static Students()
        {
            count = 0;
            Console.WriteLine("Static Constructor Called");
        }

        // Default Constructor
        public Students()
        {
            count++;

            Console.Write("Enter ID: ");
            StudentID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            studentName = Console.ReadLine();

            Console.Write("Enter Fee: ");
            fee = Convert.ToDouble(Console.ReadLine());

            Year = StudentYear.FirstYear;
            Addr = new Address("Unknown", "Unknown");
        }

        // Parameterized Constructor
        public Students(int id, string name, double fee, StudentYear year, Address addr)
        {
            count++;

            StudentID = id;
            studentName = name;
            this.fee = fee;
            Year = year;
            Addr = addr;
        }

        // Copy Constructor
        public Students(Students objCopy)
        {
            count++;

            StudentID = objCopy.StudentID;
            studentName = objCopy.studentName;
            fee = objCopy.fee;
            Year = objCopy.Year;
            Addr = objCopy.Addr;
        }

        public void DisplayData()
        {
            Console.WriteLine($"ID: {StudentID}, Name: {studentName}, Fees: {fee}, Dept: {Dept}, Year: {Year}");
            Addr.ShowAddress();
        }

        public static void ShowCount()
        {
            Console.WriteLine("Total Students = " + count);
        }

        public override string ToString()
        {
            return $"[{StudentID}] {studentName} - {Year}";
        }
    }

    // Generic Class
    public class StudentStores<T>
    {
        private List<T> items = new List<T>();

        public void AddItem(T item)
        {
            items.Add(item);
        }

        public void ShowItems()
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }


        static void Main(string[] args)
        {
            Students.Address a1 = new Students.Address("Delhi", "India");

            Students s1 = new Students(101, "Diksha", 20000, Students.StudentYear.SecondYear, a1);
            Students s2 = new Students(s1);

            s1.DisplayData();
            Console.WriteLine();
            s2.DisplayData();

            Student.ShowCount();

            StudentStores<Students> store = new StudentStores<Students>();
            store.AddItem(s1);
            store.AddItem(s2);

            Console.WriteLine("\nGeneric Store contains Student Objects:");
            store.ShowItems();

        }
    }
}
