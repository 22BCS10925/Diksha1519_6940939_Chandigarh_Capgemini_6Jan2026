using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using IdentityDemo.Data;

var builder = WebApplication.CreateBuilder(args);

// 🔹 Add DB Connection
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// 🔹 Add Identity
builder.Services.AddDefaultIdentity<IdentityUser>(options => 
    options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<ApplicationDbContext>();

// MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Middleware
app.UseAuthentication(); // IMPORTANT
app.UseAuthorization();

app.MapDefaultControllerRoute();
app.MapRazorPages(); // IMPORTANT for Identity

app.Run();