using Microsoft.AspNetCore.Mvc;
using MicroservicesSolution.DeliveryService.Data;
using MicroservicesSolution.DeliveryService.Models;

namespace MicroservicesSolution.DeliveryService.Controllers
{
    [ApiController]
    [Route("api/delivery")]
    public class DeliveryController : ControllerBase
    {
        private readonly DeliveryDbContext _context;

        public DeliveryController(DeliveryDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult CreateDelivery(Delivery delivery)
        {
            delivery.Status = "Out for Delivery";

            _context.Deliveries.Add(delivery);
            _context.SaveChanges();

            return Ok(delivery);
        }
    }
}
