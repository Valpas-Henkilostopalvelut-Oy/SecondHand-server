namespace SecondHand.Domain.Entities
{
    public class LocationBusinesses : BaseEntity
    {
        public Guid LocationId { get; set; }
        public Guid BusinessId { get; set; }
        public Locations Location { get; set; } = null!;
        public Businesses Business { get; set; } = null!;
    }
}