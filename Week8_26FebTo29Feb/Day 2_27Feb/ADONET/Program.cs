using System;
using System.Data;
using Microsoft.Data.SqlClient;


namespace ADONET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string connectionString = "Server=DESKTOP-ELLK6DL\\SQLEXPRESS;" + "Initial Catalog=UniversityDB;" + "Integrated Security=True;" + "TrustServerCertificate=True;";

                GetAllStudents(connectionString);
                InsertIntoStudent(connectionString,
                    "Diksha",
                    "Tandon",
                    "diksha@gmail.com",
                    "Information Technology"

                    );

                UpdateIntoStudent(
                    connectionString,
                    3,
                    "Charlie",
                    "Brown",
                    "charlie@uni.com",
                    "Information Technology",
                    3
                    );

                DeleteStudent(connectionString, 2);

               

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }

            Console.ReadLine();
        }
        //Insert Into Student
        static void InsertIntoStudent(
            string connectionString,
            string firstName,
            string lastName,
            string email,
            string deptName
             )
        {
            Console.WriteLine("InsertIntoStudentsWithDepID Stored Procedure Called");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command =
                    new SqlCommand("InsertIntoStudentWithDeptID", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@DeptName", deptName);


                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                Console.WriteLine(" inserted  successfully.\n");
            }
        }
        // Update Into student
        static void UpdateIntoStudent(
                   string connectionString,
                   int StudentID,
                   string firstName,
                   string lastName,
                   string email,
                   string DeptName, 
                    int DeptID)
        {
            Console.WriteLine("UpdateIntoStudent Stored Procedure Called");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command =
                    new SqlCommand("UpdateStudentsWithDept", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@StudentID", StudentID);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@DeptName", DeptName);
                command.Parameters.AddWithValue("@DeptID", DeptID);


                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                Console.WriteLine(" updated successfully.\n");
            }
        }

        // ================= DELETE Student =================
        static void DeleteStudent(string connectionString, int StudentID)
        {
            Console.WriteLine("DeleteStudent Stored Procedure Called");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command =
                    new SqlCommand("DeleteStudent", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@StudentID", StudentID);

                connection.Open();
                int result = command.ExecuteNonQuery();

                if (result > 0)
                    Console.WriteLine("student department deleted successfully.\n");
                else
                    Console.WriteLine("Student not found.\n");

                connection.Close();
            }
        }
        // ================= GET ALL Students =================
        static void GetAllStudents(string connectionString)
        {
            Console.WriteLine("GetAllStudents Stored Procedure Called");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command =
                    new SqlCommand("GetAllStudent", connection);
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(
                        $"StudentID: {reader["StudentID"]}, " +
                        $"FirstName: {reader["FirstName"]}, " +
                        $"LastName: {reader["LastName"]}, " +
                        $"Email: {reader["Email"]}"
                    );

                    Console.WriteLine(
                      //  $"DeptId: {reader["DeptId"]}, " +
                        $"DeptName: {reader["DeptName"]}\n"

                    );
                }

                reader.Close();
                connection.Close();
            }
        }

    }
}
