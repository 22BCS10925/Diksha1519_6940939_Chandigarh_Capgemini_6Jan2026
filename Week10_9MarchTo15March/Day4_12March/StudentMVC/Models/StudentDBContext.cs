using Microsoft.EntityFrameworkCore;

namespace StudentMVC.Models
{
    public class StudentDBContext : DbContext
    {
        public StudentDBContext(DbContextOptions<StudentDBContext> options)
      : base(options)
        {

        }
        public DbSet<Student> students { get; set; }
    }
}