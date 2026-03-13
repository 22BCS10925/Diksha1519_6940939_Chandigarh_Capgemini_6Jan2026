using System;
using System.Collections.Generic;

namespace Class_member
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

    internal class Student
    {
        static int count;
        public const string Dept = "CSE";
        public readonly int StudentID;
        string studentName;
        double fee;

        public StudentYear Year;
        public Address Addr;

        // Static Constructor
        static Student()
        {
            count = 0;
            Console.WriteLine("Static Constructor Called");
        }

        // Default Constructor
        public Student()
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
        public Student(int id, string name, double fee, StudentYear year, Address addr)
        {
            count++;

            StudentID = id;
            studentName = name;
            this.fee = fee;
            Year = year;
            Addr = addr;
        }

        // Copy Constructor
        public Student(Student objCopy)
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

        // For Generic Store display
        public override string ToString()
        {
            return $"[{StudentID}] {studentName} - {Year}";
        }
    }

    // Generic Class
    public class StudentStore<T>
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
    }


    class Program
    {
        static void Main(string[] args)
        {
            Address a1 = new Address("Delhi", "India");

            Student s1 = new Student(101, "Diksha", 20000, StudentYear.SecondYear, a1);
            Student s2 = new Student(s1);

            s1.DisplayData();
            Console.WriteLine();
            s2.DisplayData();

            Student.ShowCount();

            // Using Generic Class
            StudentStore<Student> store = new StudentStore<Student>();
            store.AddItem(s1);
            store.AddItem(s2);

            Console.WriteLine("\nGeneric Store contains Student Objects:");
            store.ShowItems();
        }
    }
}
