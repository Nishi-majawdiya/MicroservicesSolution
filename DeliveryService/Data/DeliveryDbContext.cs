using Microsoft.EntityFrameworkCore;
using MicroservicesSolution.DeliveryService.Models;

namespace MicroservicesSolution.DeliveryService.Data
{
    public class DeliveryDbContext : DbContext
    {
        public DeliveryDbContext(DbContextOptions<DeliveryDbContext> options) : base(options)
        {
        }

        public DbSet<Delivery> Deliveries { get; set; }
    }
}