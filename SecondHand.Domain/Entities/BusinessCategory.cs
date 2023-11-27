namespace SecondHand.Domain.Entities
{
    public class BusinessCategory
    {
        public required Guid BusinessId { get; set; }
        public required Guid CategoryId { get; set; }
        public required Businesses Business { get; set; }
        public required Categories Category { get; set; }
    }
}