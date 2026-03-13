using Microsoft.EntityFrameworkCore;
namespace CollegeManagement.Models
{
    class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }
        public DbSet<Student> students { get; set; }
    }
}