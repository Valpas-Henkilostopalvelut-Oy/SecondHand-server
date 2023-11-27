namespace SecondHand.Domain.Entities
{
    public class Locations : BaseEntity
    {
        public required string Name { get; set; }
        public Guid? BusinessId { get; set; }
        public Businesses? Business { get; set; }

        public string? Driveto { get; set; }
        public string? Iframe { get; set; }
        public required int ZipCode { get; set; }
        public required string Address { get; set; }
        public required string City { get; set; }
        public required string AdminName { get; set; }
        public required string Country { get; set; }
    }
}
