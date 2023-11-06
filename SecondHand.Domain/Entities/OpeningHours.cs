using System.ComponentModel.DataAnnotations.Schema;

namespace SecondHand.Domain.Entities
{
    public class OpeningHours : BaseEntity
    {
        [ForeignKey("Id")]
        public Guid BusinessId { get; set; }
        public Businesses? Business { get; set; }
        public int Day { get; set; }
        public DateTime OpenTime { get; set; }
        public DateTime CloseTime { get; set; }
        public bool IsClosed { get; set; }
        public int Type { get; set; }
    }
}