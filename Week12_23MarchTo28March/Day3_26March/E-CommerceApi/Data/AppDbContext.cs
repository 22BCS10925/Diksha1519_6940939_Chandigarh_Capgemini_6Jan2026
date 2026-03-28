using E_CommerceApi.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace E_CommerceApi.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }
    }

}
