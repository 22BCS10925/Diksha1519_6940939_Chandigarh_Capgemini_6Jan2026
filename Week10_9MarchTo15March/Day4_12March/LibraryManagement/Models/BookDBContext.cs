using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Models
{
   public  class BookDBContext : DbContext
    {
        public BookDBContext(DbContextOptions<BookDBContext> options) : base(options)
        {
        }
        public DbSet<Library> books { get; set; }
    }
}
