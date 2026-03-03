namespace MiniProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            List<Student> students = new List<Student>
            {
                new Student { StudentID = 101, Name = "Diksha", Age = 20, DepartmentID = 1 },
                new Student { StudentID = 102, Name = "Rahul", Age = 21, DepartmentID = 1 },
                new Student { StudentID = 103, Name = "Anita", Age = 22, DepartmentID = 2 },
                new Student { StudentID = 104, Name = "Suresh", Age = 20, DepartmentID = 3 }
            };

            // Departments
            List<Department> departments = new List<Department>
            {
                new Department { DepartmentID = 1, DepartmentName = "CSE" },
                new Department { DepartmentID = 2, DepartmentName = "ECE" },
                new Department { DepartmentID = 3, DepartmentName = "MECH" }
            };

            // Courses
            List<Course> courses = new List<Course>
            {
                new Course { CourseID = 1, CourseName = "Data Structures", DepartmentID = 1 },
                new Course { CourseID = 2, CourseName = "Operating Systems", DepartmentID = 1 },
                new Course { CourseID = 3, CourseName = "Digital Electronics", DepartmentID = 2 },
                new Course { CourseID = 4, CourseName = "DataBase", DepartmentID = 3 }
            };

            // Enrollments
            List<Enrollment> enrollments = new List<Enrollment>
            {
                new Enrollment { EnrollmentID = 1, StudentID = 101, CourseID = 1, Grade = "A" },
                new Enrollment { EnrollmentID = 2, StudentID = 101, CourseID = 2, Grade = "B" },
                new Enrollment { EnrollmentID = 3, StudentID = 102, CourseID = 1, Grade = "A" },
                new Enrollment { EnrollmentID = 4, StudentID = 103, CourseID = 3, Grade = "A" },
                new Enrollment { EnrollmentID = 5, StudentID = 104, CourseID = 4, Grade = "C" }
            };


            //Practice questions;
            Record obj = new Record();

            obj.GetOlderStudents(students);

            obj.getRecord(departments, courses);

            obj.getEnrollment(enrollments, courses);

        }
    }
}
