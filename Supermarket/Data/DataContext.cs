using Microsoft.EntityFrameworkCore;
using Supermarket.Data.Mappings;
using Supermarket.Models;

namespace Supermarket.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Server = localhost, 1433; Database = Market; User ID = sa; 
                                            Password = yourPassword; TrustServerCertificate = True");

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CategoryMapping());
            builder.ApplyConfiguration(new ProductMapping());
        }
    }
}