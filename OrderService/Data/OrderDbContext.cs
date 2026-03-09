using Microsoft.EntityFrameworkCore;
using MicroservicesSolution.OrderService.Models;

namespace MicroservicesSolution.OrderService.Data
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> options)
            : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .Property(o => o.Price)
                .HasPrecision(18, 2);
        }
    }
}