namespace SecondHand.Domain.Entities
{
    public class Images : BaseEntity
    {
        public required string OriginalName { get; set; }
        public required string FileName { get; set; }
        public required string Path { get; set; }
    }
}