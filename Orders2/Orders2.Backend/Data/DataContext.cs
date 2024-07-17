using Microsoft.EntityFrameworkCore;
using Orders2.Shared.Entities;

namespace Orders2.Backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {            
        }

        public DbSet<Country> MyProperty { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c=>c.Name).IsUnique();
        }

    }
}
