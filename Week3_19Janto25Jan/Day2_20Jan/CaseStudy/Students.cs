using System;

namespace CaseStudy
{
    public class Student
    {
        public int ID;
        public string? Name;
        public double Marks10;
        public double Marks12;
        public bool CertificateSubmitted;
        public bool FeesPaid;
        public bool HasDue;
        public double MSTMarks;
        public bool AdmissionApproved;

        public void CheckAdmission()
        {
            if (Marks10 >= 40 && Marks12 >= 40 && CertificateSubmitted)
            {
                AdmissionApproved = true;
                Console.WriteLine("✅ Admission Approved");
            }
            else
            {
                AdmissionApproved = false;
                Console.WriteLine("❌ Admission Denied");
            }
        }

        public void CheckFinalEligibility()
        {
            if (!AdmissionApproved)
            {
                Console.WriteLine("❌ Student not admitted.");
                return;
            }

            if (!FeesPaid)
            {
                Console.WriteLine("❌ Fees not paid.");
                return;
            }

            if (HasDue)
            {
                Console.WriteLine("❌ Previous dues pending.");
                return;
            }

            if (MSTMarks < 40)
            {
                Console.WriteLine("❌ Not eligible for Final Exam (MST Failed)");
                return;
            }

            Console.WriteLine("🎉 Eligible for Final Examination!");
        }

        public void Display()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"10th: {Marks10}%");
            Console.WriteLine($"12th: {Marks12}%");
            Console.WriteLine($"Certificate: {CertificateSubmitted}");
            Console.WriteLine($"Fees Paid: {FeesPaid}");
            Console.WriteLine($"Has Due: {HasDue}");
            Console.WriteLine($"MST Marks: {MSTMarks}");
            Console.WriteLine("---------------------------");
        }
    }
}