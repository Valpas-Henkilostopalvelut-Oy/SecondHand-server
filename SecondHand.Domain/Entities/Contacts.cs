

namespace SecondHand.Domain.Entities
{
    public class Contacts : BaseEntity
    {
        public Guid BusinessId { get; set; }
        public Businesses? Business { get; set; }
        public string? ContactName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}