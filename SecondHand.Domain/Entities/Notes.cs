namespace SecondHand.Domain.Entities
{
    public class Notes : BaseEntity
    {
        public string Text { get; set; } = null!;
        public Guid CustomerId { get; set; }
        public Customers Customer { get; set; } = null!;
        public Guid BusinessId { get; set; }
        public Businesses Business { get; set; } = null!;
    }
}