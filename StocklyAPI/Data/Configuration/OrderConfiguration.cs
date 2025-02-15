using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StocklyAPI.Models;

namespace StocklyAPI.Data.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");

            builder.Property(x => x.Id)
                .HasColumnName("Order_Id");

            builder.Property(o => o.CustomerId)
             .IsRequired();

            builder.Property(o => o.CustomerName)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(o => o.ShippingAddress)
                .HasMaxLength(250);

            builder.Property(o => o.OrderDate)
                .IsRequired();

            builder.Property(o => o.Status)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(o => o.TotalAmount)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.Property(o => o.PaymentMethod)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(o => o.TrackingNumber)
                .HasMaxLength(50);

            // 🔹 Restrição: Data do pedido não pode ser no futuro
            builder.HasCheckConstraint("CK_Order_OrderDate_Valid", "OrderDate <= GETDATE()");

            // 🔹 Restrição: TotalAmount não pode ser negativo
            builder.HasCheckConstraint("CK_Order_TotalAmount_NonNegative", "TotalAmount >= 0");

            // 🔹 Relacionamento: Um cliente pode ter muitos pedidos
            builder.HasOne(o => o.Customer)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CustomerId);
        }
    }
}
