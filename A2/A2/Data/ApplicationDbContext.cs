using A2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace A2.Data
{
    public class ApplicationDbContext : IdentityDbContext<A2User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SeedRoles(modelBuilder);
            SeedProducts(modelBuilder);
        }

        private void SeedRoles(ModelBuilder modelBuilder)
        {
            var roles = new[]
            {
                new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Name = "User", NormalizedName = "USER" },
                new IdentityRole { Name = "Editor", NormalizedName = "EDITOR" }
            };
            modelBuilder.Entity<IdentityRole>().HasData(roles);
        }
        
        private void SeedProducts(ModelBuilder modelBuilder)
        {
            var products = new[]
            {
                new Product
                {
                    Id = 1,
                    Name = "Anker Headphone",
                    ShortDescription = "High-quality wireless headphone with noise cancellation",
                    Description = "Experience superior sound quality with Anker's noise-cancelling wireless headphones, designed for long-lasting comfort and perfect for on-the-go music lovers.",
                    Price = 49.99m,
                    Image = "images/a.jpg",
                    IsFeatured = true
                },
                new Product
                {
                    Id = 2,
                    Name = "Insta Camera",
                    ShortDescription = "Instant camera for capturing memories",
                    Description = "Capture and print photos instantly with the Insta Camera, featuring retro design and easy-to-use functionality, ideal for events and outings.",
                    Price = 29.99m,
                    Image = "images/b.jpg",
                    IsFeatured = true
                },
                new Product
                {
                    Id = 3,
                    Name = "Apple Watch",
                    ShortDescription = "Smartwatch with health tracking features",
                    Description = "Stay connected and monitor your health metrics with the latest Apple Watch, featuring advanced sensors and a sleek design for everyday wear.",
                    Price = 59.99m,
                    Image = "images/c.jpg",
                    IsFeatured = true
                }
            };

            modelBuilder.Entity<Product>().HasData(products);
        }

    }
}