namespace SecondHand.Domain.Entities
{
    public class Ads : BaseEntity
    {
        public string? Title { get; set; }
        public string? Image { get; set; }
        public string? Description { get; set; }
        public int Price { get; set; }
        public int Status { get; set; }
    }
}