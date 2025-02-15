using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StocklyAPI.Models;

namespace StocklyAPI.Data.Configuration
{
    public class SalesPersonConfiguration : IEntityTypeConfiguration<SalesPerson>
    {
        public void Configure(EntityTypeBuilder<SalesPerson> builder)
        {
            builder.ToTable("Sales");

            builder.Property(x => x.Id)
                .HasColumnName("Sales_Id");

            builder.Property(x => x.SalesCount)
                .HasDefaultValue(0);

            builder.Property(x=>x.TotalSales)
                .HasDefaultValue(0);

            builder.Property(x => x.HireDate)
                .IsRequired();

            builder.Property(x => x.IsActive)
                .IsRequired()
                .HasDefaultValue(true);

            builder.Property(x => x.ContactNumber)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(x => x.HasElevatedPrivileges)
                .IsRequired()
                .HasDefaultValue(true);

            // 🔹 Restrição: Data de registro não pode ser futura
            builder.HasCheckConstraint("CK_Sales_HireDate_Valid", "HireDate <= GETDATE()");
        }
    }
}
