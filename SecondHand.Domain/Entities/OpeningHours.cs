namespace SecondHand.Domain.Entities
{
    public class OpeningHours : BaseEntity
    {
        public required Guid BusinessId { get; set; }
        public required Businesses Business { get; set; }
        public int Day { get; set; }
        public DateTime OpenTime { get; set; }
        public DateTime CloseTime { get; set; }
        public bool IsClosed { get; set; }
        public int Type { get; set; }
    }
}