using Magva.Domain.Entities;
using Magva.Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Magva.Infra.Data.DataContext
{
    public class MagvaDataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\OneDrive\Documentos\golairlines_db.mdf;Integrated Security=True;Connect Timeout=30");
        }

        public DbSet<Customer> Airplanes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
       
            modelBuilder.ApplyConfiguration(new CustomerMap());
        }
    }
}
