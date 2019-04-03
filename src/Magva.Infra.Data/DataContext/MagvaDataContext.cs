using Magva.Domain.Entities;
using Magva.Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Magva.Infra.Data.DataContext
{
    public class MagvaDataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=magva.database.windows.net;Initial Catalog=magva;User ID=magva;Password=********;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
       
            modelBuilder.ApplyConfiguration(new CustomerMap());
            modelBuilder.ApplyConfiguration(new CardMap());
            modelBuilder.ApplyConfiguration(new TransactionMap());
        }
    }
}
