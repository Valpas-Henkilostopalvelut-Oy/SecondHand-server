using System.ComponentModel.DataAnnotations.Schema;

namespace SecondHand.Domain.Entities
{
    public class Notes : BaseEntity
    {
        public string? NoteText { get; set; }
        [ForeignKey("Id")]
        public Guid? BusinessId { get; set; }
        public Businesses? Business { get; set; }
        [ForeignKey("Id")]
        public Guid? CustomerId { get; set; }
        public Customers? Customer { get; set; }
    }
}