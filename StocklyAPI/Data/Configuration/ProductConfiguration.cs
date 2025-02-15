using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StocklyAPI.Models;

namespace StocklyAPI.Data.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.Property(x => x.Id)
                .HasColumnName("Product_Id");

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.Description)
                .HasMaxLength(500);

            builder.Property(x => x.Quantity)
                .HasDefaultValue(0)
                .IsRequired();

            builder.Property(x => x.Price)
                .HasColumnType("decimal")
                .HasPrecision(18, 2);

            builder.Property(x => x.IsDeleted)
                .HasDefaultValue(true)
                .IsRequired();

            builder.Property(x => x.Category)
                .HasColumnType("nvarchar(20)");

            builder.Property(x => x.Weight)
                .HasColumnType("decimal")
                .HasPrecision(18, 4);

        }
    }
}
