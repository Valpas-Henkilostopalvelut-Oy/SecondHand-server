namespace SecondHand.Domain.Entities
{
    public class Locations : BaseEntity
    {
        public string Name { get; set; }
        public Guid? BusinessId { get; set; }

        public string Driveto { get; set; }
        public string Iframe { get; set; }
        public int ZipCode { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string AdminName { get; set; }
        public string Country { get; set; }
    }
}
