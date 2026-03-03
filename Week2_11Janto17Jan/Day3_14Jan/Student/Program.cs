
namespace Student
{
  
    class Program
    {
        static void Main()
        {
            Department d = new Department("Diksha", "Computer Science");

            d.CommonDetails();
            d.PersonalDetails();
            d.FeeDetails();
            d.ShowStudentBasicInfo();

            Console.WriteLine("\n--- Rules ---");
            d.AttendanceRule();
            d.UniformRule();
            d.ExamRule();

            Console.WriteLine("\n--- Services ---");
            d.LibraryAccess();
            d.LabAccess();
            d.TransportFacility();
        }
    }
}