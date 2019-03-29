using Magva.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Magva.Infra.Data.Mapping
{
    public class AddressMap : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Address");

            builder.HasKey(x => x.Id).HasName("Id");

            builder.Property(x => x.Street).HasColumnName("Street").HasMaxLength(50).HasColumnType("Varchar(50)").IsRequired();
            builder.Property(x => x.Number).HasColumnName("Number").HasMaxLength(10).IsRequired();
            builder.Property(x => x.Complement).HasColumnName("Complement").HasMaxLength(20).IsRequired();
            builder.Property(x => x.District).HasColumnName("District").HasMaxLength(30).HasColumnType("Varchar(30)").IsRequired();
            builder.Property(x => x.City).HasColumnName("City").HasMaxLength(25).HasColumnType("Varchar(25)").IsRequired();
            builder.Property(x => x.State).HasColumnName("State").HasMaxLength(25).HasColumnType("Varchar(25)").IsRequired();
            builder.Property(x => x.Country).HasColumnName("Country").HasMaxLength(25).HasColumnType("Varchar(25)").IsRequired();
            builder.Property(x => x.ZipeCode).HasColumnName("ZipeCode").HasMaxLength(10).HasColumnType("Varchar(10)").IsRequired();

        }
    }
}


