using Magva.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Magva.Infra.Data.Mapping
{
    public class CardMap : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.ToTable("Card");

            builder.HasKey(x => x.Id).HasName("Id");

            builder.Property(x => x.CardBrand).HasColumnName("CardBrand").HasMaxLength(25).HasColumnType("Varchar(25)").IsRequired();
            builder.Property(x => x.Password).HasColumnName("Password").IsRequired();
            builder.Property(x => x.Type).HasColumnName("Type").IsRequired();
            builder.Property(x => x.Active).HasColumnName("Active").IsRequired();
            builder.Property(x => x.HasPassword).HasColumnName("HasPassword").IsRequired();
            builder.Property(x => x.ExpirationDate).HasColumnName("ExpirationDate").IsRequired();
            builder.Property(x => x.Number).HasColumnName("Number").HasMaxLength(19).IsRequired();
            builder.HasOne(x => x.CardholderName);
          
        }
    }
}
