using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StocklyAPI.Models;

namespace StocklyAPI.Data.Configuration
{
    public class AdminConfiguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.ToTable("Admins");

            builder.Property(x => x.Id)
                .HasColumnName("Admin_Id");

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x=>x.RegistrationDate)
                .IsRequired();

            builder.Property(x => x.HasElevatedPrivileges)
                .IsRequired()
                .HasDefaultValue(true);


        }
    }
}
