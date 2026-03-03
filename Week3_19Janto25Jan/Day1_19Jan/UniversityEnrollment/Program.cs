namespace UniversityEnrollment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Staff st=new Staff();
            
            st.DisplayTask();

            //Professor
            
            Professor pr = new Professor();
           
            pr.DisplayCourse();

            Student student = new Student();
           
            student.DisplaySection();
        }
    }
}
