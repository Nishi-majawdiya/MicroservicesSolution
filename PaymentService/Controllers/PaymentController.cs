using Microsoft.AspNetCore.Mvc;
using MicroservicesSolution.PaymentService.Data;
using MicroservicesSolution.PaymentService.Models;

namespace MicroservicesSolution.PaymentService.Controllers
{
    [ApiController]
    [Route("api/payment")]
    public class PaymentController : ControllerBase
    {
        private readonly PaymentDbContext _context;

        public PaymentController(PaymentDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult ProcessPayment(Payment payment)
        {
            payment.Status = "Paid";

            _context.Payments.Add(payment);
            _context.SaveChanges();

            return Ok(payment);
        }
    }
}
