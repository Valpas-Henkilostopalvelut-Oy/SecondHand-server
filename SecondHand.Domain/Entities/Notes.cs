namespace SecondHand.Domain.Entities
{
    public class Notes : BaseEntity
    {
        public string? NoteText { get; set; }
        public Guid? BusinessId { get; set; }
        public Businesses? Business { get; set; }
        public Guid? CustomerId { get; set; }
        public Customers? Customer { get; set; }
    }
}