using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Supermarket.Models;

namespace Supermarket.Data.Mappings
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn();

            builder.Property(x => x.Name).IsRequired().HasColumnName("Name").HasColumnType("VARCHAR")
                .HasMaxLength(120);
            
            builder.Property(x => x.Price).IsRequired().HasColumnName("Price").HasColumnType("DECIMAL")
                .HasPrecision(18, 2);

            //one-to-many relationship, where one product has one category and a category has many products 
            builder.HasOne(x => x.Category).WithMany(x => x.Products)
                .HasConstraintName("Fk_Product_Category"); 
        }
    }
}