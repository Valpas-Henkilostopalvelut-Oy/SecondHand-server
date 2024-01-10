namespace SecondHand.Domain.Entities
{
    public class Customers : BaseEntity
    {

        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public CustomerRole Role { get; set; }
        public string? Phone { get; set; }
        public string Password { get; set; } = null!;
        public byte[] Salt { get; set; } = null!;
        public string? Avatar { get; set; }
        public List<Businesses>? Businesses { get; set; }
        public List<Notes>? Notes { get; set; }
        public List<Orders>? Orders { get; set; }
    }
    public enum CustomerRole
    {
        User,
        Admin
    }
}
