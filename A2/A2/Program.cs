using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using A2.Data;
using A2.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ??
                       throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Add Identity services
builder.Services.AddIdentity<A2User, IdentityRole>(options =>
    {
        options.Password.RequireDigit = true;
        options.Password.RequireLowercase = true;
        options.Password.RequireNonAlphanumeric = true;
        options.User.RequireUniqueEmail = true;
        options.Lockout.MaxFailedAccessAttempts = 10;
    })
    .AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();
builder.Services.ConfigureApplicationCookie(options => { options.AccessDeniedPath = "/Auth/AccessDenied"; options.LoginPath = "/Auth/Login";  options.LogoutPath = "/Auth/Logout"; });

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

/* For full documentation on this project, check readme.md  */

/*

API Endpoints and Access Control

(Access to all)
- /Home or /  
- /Auth
    - /Login
    - /Register   

(Access to users with role "User", "Editor", "Admin")
  - /Products     
     - /Details/{id}

(Access to users with role "Editor", "Admin")
 - /Inventory         
     - /Inventory/Create
     - /Inventory/Edit/{id}
     - /Inventory/Delete/{id}

(Access to users with role "Admin")
 - /Admin         
     - /
     - /AddUser
     
*/