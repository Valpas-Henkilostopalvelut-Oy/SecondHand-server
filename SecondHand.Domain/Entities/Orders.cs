namespace SecondHand.Domain.Entities
{
    public class Orders : BaseEntity
    {
        public required Guid CustomerId { get; set; }
        public required Customers Customer { get; set; }
        public List<Businesses>? Businesses { get; set; }
        public required DateTime Date { get; set; }
        public int Status { get; set; }
        public int TotalPrice { get; set; }
        public int TotalQuantity { get; set; }
    }
}