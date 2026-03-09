namespace MicroservicesSolution.DeliveryService.Models
{
    public class Delivery
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public string Address { get; set; }

        public string Status { get; set; }
    }
}
