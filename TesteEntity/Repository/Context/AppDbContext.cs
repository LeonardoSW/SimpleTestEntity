using Microsoft.EntityFrameworkCore;
using TesteEntity.Domain;
using TesteEntity.Repository.Configuration;

namespace TesteEntity.Repository.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<ProductsEntity> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductsMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
