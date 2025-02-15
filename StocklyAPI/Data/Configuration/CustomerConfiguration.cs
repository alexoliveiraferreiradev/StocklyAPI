using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StocklyAPI.Models;

namespace StocklyAPI.Data.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");

            builder.Property(x => x.Id)
                .HasColumnName("Customer_Id");

            builder.Property(c => c.FullName)
            .IsRequired()
            .HasMaxLength(150);

            builder.Property(c => c.ShippingAddress)
           .HasMaxLength(250);

            builder.Property(c => c.DateOfBirth)
                .IsRequired();

            builder.Property(c => c.IsEmailVerified)
                .HasDefaultValue(false);

            builder.Property(c => c.IsActive)
                .HasDefaultValue(true);

            // 🔹 Restrição: Data de nascimento não pode ser futura
            builder.HasCheckConstraint("CK_Customer_DateOfBirth_Valid", "DateOfBirth <= GETDATE()");
        }
    }
}
