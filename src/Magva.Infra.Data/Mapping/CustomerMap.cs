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

            builder.HasKey(x => x.Id);


            builder.Property(x => x.Name)
                .HasColumnName("Name")
                .HasColumnType("Varchar(40)")
                .IsRequired();

            builder.Property(x => x.Email)
                .HasColumnName("Email")
                .HasColumnType("Varchar(25)")
                .IsRequired();

            builder.Property(x => x.Document)
            .HasColumnName("Document")
            .HasColumnType("Varchar(11)")
            .IsRequired();


            builder.Property(x => x.Phone)
                .HasColumnName("Phone")
                .HasMaxLength(50)
                .HasColumnType("Varchar(50)")
                .IsRequired();

            builder.HasMany(x => x.Transactions);

        }
    }
}
