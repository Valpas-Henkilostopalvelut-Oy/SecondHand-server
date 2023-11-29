namespace SecondHand.Application.Dtos
{
    public class CreateLocationsDTO
    {
        public required string Name { get; set; }
        public Guid? BusinessId { get; set; }
        public string? Driveto { get; set; }
        public string? Iframe { get; set; }
        public required int ZipCode { get; set; }
        public required string Address { get; set; }
        public required string City { get; set; }
        public required string AdminName { get; set; }
        public required string Country { get; set; }
    }
    public class UpdateLocationsDTO
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public Guid? BusinessId { get; set; }
        public string? Driveto { get; set; }
        public string? Iframe { get; set; }
        public int? ZipCode { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? AdminName { get; set; }
        public string? Country { get; set; }
    }
}