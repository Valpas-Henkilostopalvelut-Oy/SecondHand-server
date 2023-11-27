

namespace SecondHand.Domain.Entities
{
    public class Businesses : BaseEntity
    {
        public required Guid CustomerId { get; set; }
        public required Customers Customer { get; set; }

        public required string Name { get; set; }
        public string? Description { get; set; }
        public string? WebsiteUrl { get; set; }
        public string? LogoUrl { get; set; }
        public string[]? Images { get; set; }

        public List<OpeningHours>? OpeningHours { get; set; }
        public List<Contacts>? Contacts { get; set; }
        public List<Notes>? Notes { get; set; }
        public Socials? Socials { get; set; }
        public List<Locations>? Locations { get; set; }
        public List<Categories>? Categories { get; set; }
        public List<BusinessCategory>? BusinessCategories { get; set; }
        public List<Orders>? Orders { get; set; }
    }
}