namespace Student
{
    
    abstract class Documents
    {
        public string CourseName;
        public string StuName;

        protected double PhoneNo;
        protected string MailId;
        protected double FeeStructure;

       
        public abstract void PersonalDetails();
        public abstract void FeeDetails();
        public abstract void ShowStudentBasicInfo();

        
        public void CommonDetails()
        {
            Console.WriteLine("Common Details :");
            Console.WriteLine("Student Name: " + StuName);
            Console.WriteLine("Course Selected: " + CourseName);
        }
    }


    interface StudentRules
    {
        void AttendanceRule();
        void UniformRule();
        void ExamRule();
    }

   
    interface StudentServices
    {
        void LibraryAccess();
        void LabAccess();
        void TransportFacility();
    }

    
    class Department : Documents, StudentRules, StudentServices
    {
        public Department(string studentName, string courseName)
        {
            StuName = studentName;
            CourseName = courseName;
        }

        
        public override void PersonalDetails()
        {
            Console.WriteLine("\n--- Enter Personal Details ---");

            Console.Write("Phone Number: ");
            PhoneNo = double.Parse(Console.ReadLine());

            Console.Write("Mail Id: ");
            MailId = Console.ReadLine();
        }

        public override void FeeDetails()
        {
            Console.Write("Enter Fee Amount: ");
            FeeStructure = double.Parse(Console.ReadLine());
        }

        public override void ShowStudentBasicInfo()
        {
            Console.WriteLine("\n--- Student Info ---");
            Console.WriteLine("Name: " + StuName);
            Console.WriteLine("Course: " + CourseName);
        }

   
        public void AttendanceRule()
        {
            Console.WriteLine("Rule: Minimum 75% attendance required");
        }

        public void UniformRule()
        {
            Console.WriteLine("Rule: Uniform mandatory on Wednesdays");
        }

        public void ExamRule()
        {
            Console.WriteLine("Rule: Must attend all internal exams");
        }

       
        public void LibraryAccess()
        {
            Console.WriteLine("Service: Library access available");
        }

        public void LabAccess()
        {
            Console.WriteLine("Service: Lab access available");
        }

        public void TransportFacility()
        {
            Console.WriteLine("Service: Transport facility available");
        }
    }
}

    
