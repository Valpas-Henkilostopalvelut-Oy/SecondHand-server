using System.ComponentModel.DataAnnotations.Schema;

namespace SecondHand.Domain.Entities
{
    public class Socials : BaseEntity
    {
        [ForeignKey("Id")]
        public Guid? BusinessId { get; set; }
        public Businesses? Business { get; set; }
        public string Facebook { get; set; } 
        public string Twitter { get; set; }
        public string Instagram { get; set; }
        public string Youtube { get; set; }
        public string Tiktok { get; set; }
    }
}