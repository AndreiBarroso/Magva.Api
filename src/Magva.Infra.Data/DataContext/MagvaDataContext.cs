using Magva.Domain.Entities;
using Magva.Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Magva.Infra.Data.DataContext
{
    public class MagvaDataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\OneDrive\Documentos\golairlines_db.mdf;Integrated Security=True;Connect Timeout=30");

            //optionsBuilder
            //    .EnableSensitiveDataLogging(true)
            //    .UseLoggerFactory(new LoggerFactory().AddConsole((category, level) =>
            //    level == LogLevel.Information &&
            //    category == DbLoggerCategory.Database.Command.Name, true));
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
