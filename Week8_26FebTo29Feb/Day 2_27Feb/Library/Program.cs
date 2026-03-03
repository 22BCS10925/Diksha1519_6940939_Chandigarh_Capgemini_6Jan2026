using System;
using System.Data;
using Microsoft.Data.SqlClient;
namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
             string connectionString =
             "Server=DESKTOP-ELLK6DL\\SQLEXPRESS;" +
             "Database=LibraryDB;" +
             "Integrated Security=True;" +
             "TrustServerCertificate=True;";

         
                DataSet ds = new DataSet();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();

                    // ================= SELECT =================
                    adapter.SelectCommand = new SqlCommand("sp_GetAllBooks", conn);
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                    // ================= INSERT =================
                    adapter.InsertCommand = new SqlCommand("sp_InsertBook", conn);
                    adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                    adapter.InsertCommand.Parameters.Add("@Title", SqlDbType.NVarChar, 200, "Title");
                    adapter.InsertCommand.Parameters.Add("@AuthorId", SqlDbType.Int, 0, "AuthorId");
                    adapter.InsertCommand.Parameters.Add("@PublishedYear", SqlDbType.Int, 0, "PublishedYear");

                    // ================= UPDATE =================
                    adapter.UpdateCommand = new SqlCommand(" sp_UpdateBook", conn);
                    adapter.UpdateCommand.CommandType = CommandType.StoredProcedure;
                    adapter.UpdateCommand.Parameters.Add("@BookId", SqlDbType.Int, 0, "BookId");
                    adapter.UpdateCommand.Parameters.Add("@Title", SqlDbType.NVarChar, 200, "Title");
                    adapter.UpdateCommand.Parameters.Add("@AuthorId", SqlDbType.Int, 0, "AuthorId");
                    adapter.UpdateCommand.Parameters.Add("@PublishedYear", SqlDbType.Int, 0, "PublishedYear");

                    // ================= DELETE =================
                    adapter.DeleteCommand = new SqlCommand("sp_DeleteBookRecord", conn);
                    adapter.DeleteCommand.CommandType = CommandType.StoredProcedure;
                    adapter.DeleteCommand.Parameters.Add("@BookId", SqlDbType.Int, 0, "BookId");

                    // Fill Data (Disconnected)
                    adapter.Fill(ds, "Books");

                    DataTable table = ds.Tables["Books"];

                    Console.WriteLine("=== Existing Books ===");
                    foreach (DataRow row in table.Rows)
                    {
                        Console.WriteLine($"{row["BookId"]} - {row["Title"]}");
                    }

                    // ================= INSERT (Offline) =================
                    DataRow newRow = table.NewRow();
                    newRow["Title"] = "Animal Farm";
                    newRow["AuthorId"] = 3;
                    newRow["PublishedYear"] = 1945;
                    table.Rows.Add(newRow);

                    // ================= UPDATE (Offline) =================
                    if (table.Rows.Count > 0)
                    {
                        table.Rows[0]["Title"] = "Harry Potter Updated";
                    }

                    // ================= DELETE (Offline) =================
                    if (table.Rows.Count > 1)
                    {
                        table.Rows[1].Delete();
                    }

                // Push changes to Database
                adapter.Fill(ds, "Books");
                adapter.Update(ds, "Books");
                Console.WriteLine("\nChanges Saved Successfully.");
                }

                Console.ReadLine();
            }
        }
    }


