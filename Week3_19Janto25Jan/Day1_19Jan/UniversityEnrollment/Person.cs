using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityEnrollment
{
    public class Person
    {
        public int id;
        public string Name;
        public string dept;
        public string gender;

        public Person()
        {
            Console.WriteLine("Enter the id: ");
            this.id=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Name: ");
            this.Name = Console.ReadLine();
            Console.WriteLine("Enter the department: ");
            this.dept = Console.ReadLine();
            Console.WriteLine("Gender : ");
            this.gender = Console.ReadLine();
        }
        public void Display()
        {
            Console.WriteLine("ID of the person: " + id);
            Console.WriteLine("Name of the person: " + Name);
            Console.WriteLine("Dept of the person: " + dept);
            Console.WriteLine("Gender of the person: " + gender);
        }



    }
    public class Student : Person
    {
        public int section;
        public Student()
        {
            Console.WriteLine("Enter the section of the student: ");
            this.section= int.Parse(Console.ReadLine());
        }
        public void DisplaySection()
        {
            Console.WriteLine("ID of the Student is: " + id);
            Console.WriteLine("Name of the Student is: " + Name);
            Console.WriteLine("Student assigned to this section: " + section);
        }

    }
    public class Professor : Person
    {
       public string course;
       public Professor()
        {
            Console.WriteLine("Enter the assigned course: ");
            this.course = Console.ReadLine();
        }
        public void DisplayCourse()
        {
            Console.WriteLine("ID of the Professor is: " + id);
            Console.WriteLine("Name of the Professor is: " + Name);
            Console.WriteLine("Course Assigned to Professor is: " + course);
        }


    }
    public class Staff : Person
    {
        public string task;
        public Staff()
        {
            Console.WriteLine("Enter the assigned task: ");
            this.task = Console.ReadLine();
        }
        public void DisplayTask()
        {
            Console.WriteLine("ID of the Staff is: " + id);
            Console.WriteLine("Name of the Staff is: " + Name);
            Console.WriteLine("Course Assigned to Staff is: " + task);
        }

    }
}
