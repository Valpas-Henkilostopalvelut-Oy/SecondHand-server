using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SecondHand.Domain.Entities
{
    public class BaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public Guid Id { get; set; }
        public required DateTime CreatedAt { get; set; }
        public DateTime LastModifiedAt { get; set; }
        public required bool IsDeleted { get; set; }
        public DateTime DeletedAt { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid LastModifiedBy { get; set; }
        public Guid DeletedBy { get; set; }
        public required byte[] RowVersion { get; set; }
        public required int Version { get; set; }
    }
}
