using MongoDB.Bson.Serialization.Attributes;

namespace SecondHand.Domain.Entities
{
    public class Categories : BaseEntity
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public List<CategoriesBusinesses> CategoriesBusinesses { get; set; } = new List<CategoriesBusinesses>();
    }
}