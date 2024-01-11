using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SecondHand.Domain.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public Guid? DeletedBy { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public int Version { get; set; }
    }
}
