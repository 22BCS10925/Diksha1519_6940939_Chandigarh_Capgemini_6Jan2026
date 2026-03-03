using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagementProject
{
    internal class Student
    {

        static int count;
        public const string Dept = "CSE";
        public readonly int StudentID;
        string studentName;
        double fee;

        static Student()
        {
            count = 0;
            Console.WriteLine("Static Constructor Called");
        }

        // Default Constructor
        public Student()
        {
            count++;

            StudentID = Convert.ToInt32(Console.ReadLine());
            studentName = Console.ReadLine();
            fee = Convert.ToDouble(Console.ReadLine());

        }

        // Parameterized Constructor
        public Student(int id, string name, double fee)
        {
            count++;

            StudentID = id;
            studentName = name;
            this.fee = fee;

        }

        // Copy Constructor
        public Student(Student objCopy)
        {
            StudentID = objCopy.StudentID;
            studentName = objCopy.studentName;
            fee = objCopy.fee;

        }

        public void DisplayData()
        {
            Console.WriteLine($"ID: {StudentID}, Name: {studentName}, Fees: {fee}, Dept: {Dept}");
        }

        public static void ShowCount()
        {
            Console.WriteLine("Total Students = " + count);
        }

    }
}
