using System;
using System.Collections.Generic;

namespace CaseStudy
{
    public class Manager
    {
        private List<Student> students = new List<Student>();

        private Student? FindStudent(int id)
        {
            return students.Find(s => s.ID == id);
        }

        public void AddStudent()
        {
            Student s = new Student();

            Console.Write("Enter ID: ");
            if (int.TryParse(Console.ReadLine(), out int id))
                s.ID = id;
            else
            {
                Console.WriteLine("Invalid ID.");
                return;
            }

            Console.Write("Enter Name: ");
            s.Name = Console.ReadLine() ?? "";

            Console.Write("Enter 10th Marks: ");
            if (double.TryParse(Console.ReadLine(), out double m10))
                s.Marks10 = m10;
            else
            {
                Console.WriteLine("Invalid 10th Marks.");
                return;
            }

            Console.Write("Enter 12th Marks: ");
            if (double.TryParse(Console.ReadLine(), out double m12))
                s.Marks12 = m12;
            else
            {
                Console.WriteLine("Invalid 12th Marks.");
                return;
            }

            Console.Write("Certificate Submitted (yes/no): ");
            string? certInput = Console.ReadLine();
            s.CertificateSubmitted = certInput?.ToLower() == "yes";

            s.CheckAdmission();
            students.Add(s);
        }

        public void PayFees()
        {
            Console.Write("Enter Student ID: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Invalid ID.");
                return;
            }

            Student? s = FindStudent(id);

            if (s != null)
            {
                Console.Write("Fees Paid (yes/no): ");
                s.FeesPaid = Console.ReadLine()?.ToLower() == "yes";

                Console.Write("Has Previous Due (yes/no): ");
                s.HasDue = Console.ReadLine()?.ToLower() == "yes";
            }
            else
            {
                Console.WriteLine("Student Not Found");
            }
        }

        public void EnterMST()
        {
            Console.Write("Enter Student ID: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Invalid ID.");
                return;
            }

            Student? s = FindStudent(id);

            if (s != null)
            {
                Console.Write("Enter MST Marks: ");
                if (double.TryParse(Console.ReadLine(), out double mst))
                    s.MSTMarks = mst;
                else
                    Console.WriteLine("Invalid MST Marks.");
            }
            else
            {
                Console.WriteLine("Student Not Found");
            }
        }

        public void CheckEligibility()
        {
            Console.Write("Enter Student ID: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Invalid ID.");
                return;
            }

            Student? s = FindStudent(id);

            if (s != null)
                s.CheckFinalEligibility();
            else
                Console.WriteLine("Student Not Found");
        }

        public void ViewAll()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No Students Available.");
                return;
            }

            foreach (var s in students)
                s.Display();
        }
    }
}