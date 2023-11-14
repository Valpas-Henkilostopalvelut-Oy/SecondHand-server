namespace SecondHand.Domain.Entities
{
    public class Images : BaseEntity
    {
        public string? OriginalName { get; set; }
        public string? FileName { get; set; }
        public string? Path { get; set; }
    }
}