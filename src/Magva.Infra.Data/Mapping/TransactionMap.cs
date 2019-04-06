using Magva.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Magva.Infra.Data.Mapping
{
    public class TransactionMap : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transaction");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Amount).HasColumnName("Amount").HasMaxLength(50).HasColumnName("money").IsRequired();
            builder.Property(x => x.Number).HasColumnName("Number").IsRequired();
            builder.Property(x => x.Type).HasColumnName("Type").IsRequired();
            builder.Property(x => x.DateTransaction).HasColumnName("DateTransaction").IsRequired();
            builder.Property(x => x.NumberInstallments).HasColumnName("NumberInstallments").IsRequired();

            builder.HasOne(x => x.Card);

        }
    }
}
