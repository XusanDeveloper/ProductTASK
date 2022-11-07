using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProductTASK.Data.Configuration;
using ProductTASK.Models;

namespace ProductTASK.Data.Context
{
    public class ApplicationDbContext : AuditableIdentityContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
        }
        public DbSet<Product> Products { get; set; }
    }
}