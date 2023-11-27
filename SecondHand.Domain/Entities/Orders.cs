namespace SecondHand.Domain.Entities
{
    public class Orders
    {
        public required Guid CustomerId { get; set; }
        public required Customers Customer { get; set; }
        public required Guid BusinessId { get; set; }
        public required Businesses Business { get; set; }
        public required DateTime Date { get; set; }
        public int Status { get; set; }
        public int TotalPrice { get; set; }
        public int TotalQuantity { get; set; }
    }
}