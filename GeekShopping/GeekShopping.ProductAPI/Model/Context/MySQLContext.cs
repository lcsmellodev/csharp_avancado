using GeekShopping.ProductAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Models.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext()
        {
            
        }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasData(new Product
                {
                    Id = 5,
                    Name = "Name",
                    Price = new decimal(69.8),
                    Description = "Description",
                    ImageUrl = "http://www.google.com",
                    CategoryName = "T-Shirt",
                });

            modelBuilder.Entity<Product>()
                .HasData(new Product
                {
                    Id =4,
                    Name = "Name3",
                    Price = new decimal(50),
                    Description = "Description",
                    ImageUrl = "http://www.yahoo.com",
                    CategoryName = "V-Shirt",
                });
        }

    }
}









