using Microsoft.EntityFrameworkCore;
using ECommerceOrderAPI.Models;
namespace ECommerceOrderAPI.Data

{

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Order> Orders { get; set; }

    }

}
