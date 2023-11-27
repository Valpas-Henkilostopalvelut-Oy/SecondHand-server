namespace SecondHand.Domain.Entities
{
    public class Notes : BaseEntity
    {
        public required string NoteText { get; set; }
        public required Guid BusinessId { get; set; }
        public required Businesses Business { get; set; }
        public required Guid CustomerId { get; set; }
        public required Customers Customer { get; set; }
    }
}