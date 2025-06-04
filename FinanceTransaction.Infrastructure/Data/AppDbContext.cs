using Microsoft.EntityFrameworkCore;
using FinanceTransaction.Core;
using System.Transactions;

namespace FinanceTransaction.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<User> Users { get; set; }  // if you’re doing JWT auth

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Optional: Configure table names or relationships
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
