using APBD_kol.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace APBD_kol.Configuration
{
    public class DiscountConfig : IEntityTypeConfiguration<Discount>
    {
        public void Configure(EntityTypeBuilder<Discount> builder)
        {
            builder.HasKey(e => e.IdDiscount)
                .HasName("Discount_PK");

            builder.Property(e => e.IdDiscount)
                .UseIdentityColumn();

            builder.Property(e => e.Value)
                .IsRequired();

            builder.Property(e => e.DateFrom)
                .IsRequired();

            builder.Property(e => e.DateTo)
                .IsRequired();

            builder.HasOne(e => e.IdClientNav)
                .WithMany(c => c.Discounts)
                .HasForeignKey(e => e.IdClient)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("Client_Discount_FK");

            var discounts = new List<Discount>
        {
            new()
            {
                IdDiscount = 1,
                Value = 11,
                DateFrom = DateTime.Now,
                DateTo = DateTime.Now.AddDays(30),
                IdClient = 1
            },
            new()
            {
                IdDiscount = 2,
                Value = 12,
                DateFrom = DateTime.Now,
                DateTo = DateTime.Now.AddDays(60),
                IdClient = 2
            },
            new()
            {
                IdDiscount = 3,
                Value = 15,
                DateFrom = DateTime.Now,
                DateTo = DateTime.Now.AddDays(90),
                IdClient = 3
            }
        };

            builder.HasData(discounts);
        }

    }
}
