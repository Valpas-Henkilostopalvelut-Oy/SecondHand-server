using MongoDB.Bson.Serialization.Attributes;

namespace SecondHand.Domain.Entities
{
    public class Businesses : BaseEntity
    {
        // One-to-many relationship with Customers
        public Guid? CustomerId { get; set; }
        public Customers? Customer { get; set; }

        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string? WebsiteUrl { get; set; }
        public string? LogoUrl { get; set; }
        public string[]? Images { get; set; }
        public OpeningHours? OpeningHours { get; set; }
        public List<Contacts>? Contacts { get; set; }
        public List<Notes>? Notes { get; set; }
        public Socials? Socials { get; set; }

        public List<LocationBusinesses>? Locations { get; set; }
        public List<CategoriesBusinesses>? Categories { get; set; }
        public List<Orders>? Orders { get; set; }
        public Guid? TypeId { get; set; }
        public Types? Type { get; set; }
    }

    public class Socials
    {
        public string? Facebook { get; set; }
        public string? Twitter { get; set; }
        public string? Instagram { get; set; }
        public string? Youtube { get; set; }
        public string? Tiktok { get; set; }
    }

    public class OpeningHours
    {
        public bool OpenNow { get; set; }
        public List<Period>? Periods { get; set; }
        public List<string>? WeekdayDescriptions { get; set; }
        public List<SpecialDay>? SpecialDays { get; set; }
    }

    public class Period
    {
        public TimeOfDay Open { get; set; } = null!;
        public TimeOfDay Close { get; set; } = null!;
    }

    public class TimeOfDay
    {
        public int Day { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public Date Date { get; set; } = null!;
    }

    public class Date
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
    }

    public class SpecialDay
    {
        public Date Date { get; set; } = null!;
    }


    public class Contacts
    {
        public string ContactName { get; set; } = null!;
        public string? Phone { get; set; }
        public string? Email { get; set; }
    }
}