

namespace SecondHand.Domain.Entities
{
    public class Customers : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public byte[] Salt { get; set; }
        public string Avatar { get; set; }
        public List<Businesses> Businesses { get; set; }
        public List<Notes> Notes { get; set; }
        public List<Orders> Orders { get; set; }
    }
}
