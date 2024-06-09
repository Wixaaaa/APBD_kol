using APBD_kol.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace APBD_kol.Configuration
{
    public class ClientConfig : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(c => c.IdClient)
                .HasName("Client_PK");

            builder.Property(c => c.IdClient)
                .UseIdentityColumn();

            builder.Property(c => c.FirstName)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.LastName)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.Email)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.Phone)
                .HasMaxLength(100);

            builder.HasMany(c => c.Payments)
                .WithOne(p => p.IdClientNav)
                .HasForeignKey(p => p.IdClient)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("Payment_Client_FK");

            builder.HasMany(c => c.Discounts)
                .WithOne(d => d.IdClientNav)
                .HasForeignKey(d => d.IdClient)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("Client_Discount_FK");

            builder.HasMany(c => c.Sales)
                .WithOne(s => s.IdClientNav)
                .HasForeignKey(s => s.IdClient)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("Client_Sale_FK");


            var Clients = new List<Client>
        {
            new()
            {
                IdClient = 1,
                FirstName = "Jakub",
                LastName = "Nowak",
                Email = "test@mail.com",
                Phone = "123456789"
            },
            new()
            {
                IdClient = 2,
                FirstName = "Michal",
                LastName = "Kowalski",
                Email = "test2@mail.com",
                Phone = "223456789"
            },
            new()
            {
                IdClient = 3,
                FirstName = "Client'",
                LastName = "Clientowich",
                Email = "test3@mail.com",
                Phone = "323456789"
            },
            new()
            {
                IdClient = 4,
                FirstName = "Sergio",
                LastName = "Kotowich",
                Email = "test44@mail.com",
                Phone = "123556989"
            },
            new()
            {
                IdClient = 5,
                FirstName = "Ala",
                LastName = "Peronska",
                Email = "test44@mail.com",
                Phone = "125656789"
            },
            new()
            {
                IdClient = 6,
                FirstName = "Kot",
                LastName = "Zygmund",
                Email = "test55@mail.com",
                Phone = "1233456789"
            },
            new()
            {
                IdClient = 7,
                FirstName = "Natiel",
                LastName = "Client'",
                Email = "test22@mail.com",
                Phone = "122456789"
            },
            new()
            {
                IdClient = 8,
                FirstName = "Jas",
                Email = "test11@mail.com",
                Phone = "113456789"
            }
        };

            builder.HasData(Clients);
        }
    }
}
