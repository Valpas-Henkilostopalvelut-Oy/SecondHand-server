namespace SecondHand.Domain.Entities
{
    public class BusinessCategory
    {
        public Guid BusinessId { get; set; }
        public Guid CategoryId { get; set; }
        public Businesses Business { get; set; }
        public Categories Category { get; set; }
    }
}