using MicroservicesSolution.OrderService.Data;
using MicroservicesSolution.OrderService.Models;
using Microsoft.AspNetCore.Mvc;

namespace OrderService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly OrderDbContext _context;

        public OrderController(OrderDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult CreateOrder(Order order)
        {
            order.Status = "Pending";

            _context.Orders.Add(order);
            _context.SaveChanges();

            return Ok(order);
        }

        [HttpGet]
        public IActionResult GetOrders()
        {
            return Ok(_context.Orders.ToList());
        }
    }
}