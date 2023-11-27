

namespace SecondHand.Domain.Entities
{
    public class Customers : BaseEntity
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public CustomerRole Role { get; set; }
        public string? Phone { get; set; }
        public required string Password { get; set; }
        public required byte[] Salt { get; set; }
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
