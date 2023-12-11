namespace SecondHand.Domain.Entities
{
    public class Categories : BaseEntity
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public List<BusinessCategory>? BusinessCategories { get; set; }
    }
}