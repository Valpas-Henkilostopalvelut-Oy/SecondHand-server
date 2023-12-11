

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

        //  таблицы
        public List<OpeningHours>? OpeningHours { get; set; }
        public List<Contacts>? Contacts { get; set; }
        public List<Notes>? Notes { get; set; }
        public Socials? Socials { get; set; }
        public List<Locations>? Locations { get; set; }

        public List<BusinessCategory> BusinessCategories { get; set; }
        public List<BusinessOrder> BusinessOrders { get; set; }
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
        public List<Period> Periods { get; set; }
        public List<string> WeekdayDescriptions { get; set; }
        public List<SpecialDay> SpecialDays { get; set; }
    }

    public class Period
    {
        public TimeOfDay Open { get; set; }
        public TimeOfDay Close { get; set; }
    }

    public class TimeOfDay
    {
        public int Day { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public Date Date { get; set; }
    }

    public class Date
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
    }

    public class SpecialDay
    {
        public Date Date { get; set; }
    }

    public class Notes
    {
        public required string NoteText { get; set; }
        public required Guid CustomerId { get; set; }
        public required Customers Customer { get; set; }
    }
    public class Locations
    {
        public required string Name { get; set; }
        public string? Driveto { get; set; }
        public string? Iframe { get; set; }
        public required int ZipCode { get; set; }
        public required string Address { get; set; }
        public required string City { get; set; }
        public required string AdminName { get; set; }
        public required string Country { get; set; }
    }
    public class Contacts
    {
        public string? ContactName { get; set; }
        public required string Phone { get; set; }
        public required string Email { get; set; }
    }
}