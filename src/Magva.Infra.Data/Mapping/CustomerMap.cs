using Magva.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Magva.Infra.Data.Mapping
{
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");

            builder.HasKey(x => x.Id).HasName("Id");

            builder.OwnsOne(x => x.Name, name =>
            {
                name.Property(x => x.FirstName)
                .HasColumnName("FirstName")
                .HasColumnType("Varchar()")
                .IsRequired();
            });

            builder.OwnsOne(x => x.Name, name =>
            {
                name.Property(x => x.LastName)
                .HasColumnName("LastName")
                .HasColumnType("Varchar(40)")
                .IsRequired();
            });

            builder.OwnsOne(x => x.Email, email =>
            {
                email.Property(x => x.Address)
                    .HasColumnName("Email")
                    .HasColumnType("Varchar(25)")
                    .IsRequired();
            });
            builder.OwnsOne(x => x.Document, doc =>
            {
                doc.Property(x => x.Number)
                .HasColumnName("Number")
                .HasColumnType("Varchar(11)")
                .IsRequired();
            });

            builder.Property(x => x.BirthDate).HasColumnName("BirthDate").IsRequired();
            builder.Property(x => x.Phone).HasColumnName("Phone").HasMaxLength(50).HasColumnType("Varchar(50)").IsRequired();


            builder.HasMany(x => x.Transactions).WithOne(x => x.Customer);

        }
    }
}
