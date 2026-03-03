namespace StudentManagementProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student(10925, "Diksha", 20000);
            Student s3 = new Student(s1);

            s1.DisplayData();
            s2.DisplayData();
            s3.DisplayData();

            Student.ShowCount();
        }
    }
}
