namespace SecondHand.Domain.Entities
{
    public class Types : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string? Image { get; set; }
        public List<Businesses> Businesses { get; set; } = new List<Businesses>();
    }
}