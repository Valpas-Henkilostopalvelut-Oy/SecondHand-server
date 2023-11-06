using System.ComponentModel.DataAnnotations.Schema;

namespace SecondHand.Domain.Entities
{
    public class Orders
    {
        [ForeignKey("Id")]
        public Guid CustomerId { get; set; }
        public Customers? Customer { get; set; }
        [ForeignKey("Id")]
        public Guid BusinessId { get; set; }
        public Businesses? Business { get; set; }
        public DateTime Date { get; set; } 
        public int Status { get; set; }
        public int TotalPrice { get; set; }
        public int TotalQuantity { get; set; }
        public int PaymentMethod { get; set; }
    }
}