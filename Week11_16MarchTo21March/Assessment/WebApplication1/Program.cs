using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Services
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddAuthentication("CookieAuth")
                .AddCookie("CookieAuth", options =>
                {
                    options.LoginPath = "/Account/Login";
                });

            builder.Services.AddAuthorization();

            var app = builder.Build();

            // Error handling
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapDefaultControllerRoute();
            using (var scope = app.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

                if (!context.Users.Any(u => u.Role == "Admin"))
                {
                    var customer = new Customer
                    {
                        Name = "Admin"
                        ,
                        Email = "admin@gmail.com" // ? required

                    };

                    context.Customers.Add(customer);
                    context.SaveChanges();

                    context.Users.Add(new User
                    {
                        Username = "admin",
                        Password = "123",
                        Role = "Admin",
                        CustomerId = customer.Id
                    });

                    context.SaveChanges();
                }
            }

            // ? ? ADD THIS BLOCK (Category Seed Data)
            using (var scope = app.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

                if (!context.Categories.Any())
                {
                    context.Categories.AddRange(
                        new Category { Name = "Electronics" },
                        new Category { Name = "Clothing" },
                        new Category { Name = "Books" },
                        new Category { Name = "Home & Kitchen" },
                        new Category { Name = "Beauty" }
                    );

                    context.SaveChanges();
                }
            }

            app.Run();
        }
    }
}