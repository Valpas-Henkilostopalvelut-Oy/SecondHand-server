

namespace SecondHand.Domain.Entities
{
    public class Contacts : BaseEntity
    {
        public required Guid BusinessId { get; set; }
        public Businesses? Business { get; set; }
        public string? ContactName { get; set; }
        public required string Phone { get; set; }
        public required string Email { get; set; }
    }
}