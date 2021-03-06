using EcommerceWeb.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EcommerceWeb.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Category> Countries { get; set;}
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<Category>().HasIndex(n => n.Name).IsUnique();

        }
    }
    
}
