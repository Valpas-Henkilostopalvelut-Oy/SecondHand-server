namespace SecondHand.Domain.Entities
{
    public class Orders : BaseEntity
    {
        public Guid CustomerId { get; set; }
        public Customers Customer { get; set; } = null!;
        public Guid BusinessId { get; set; }
        public Businesses Businesses { get; set; } = null!;
        public DateTime Date { get; set; }
        public int Status { get; set; }
        public int TotalPrice { get; set; }
    }
}