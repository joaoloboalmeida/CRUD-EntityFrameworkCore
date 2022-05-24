using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Supermarket.Models;

namespace Supermarket.Data.Mappings
{
    public class CategoryMapping : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");

            builder.HasKey(x => x.Id); //pk
            builder.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn(); //IDENTITY(1,1)

            builder.Property(x => x.Name).IsRequired().HasColumnName("Name")
                .HasColumnType("VARCHAR")
                .HasMaxLength(100);

            builder.HasIndex(x => x.Name, "IX_Category_Name").IsUnique();
        }
    }
}