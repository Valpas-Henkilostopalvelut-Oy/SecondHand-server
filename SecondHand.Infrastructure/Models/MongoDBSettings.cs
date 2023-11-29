using MongoDB.Bson;

namespace SecondHand.Infrastructure.Models
{
    public class MongoDBSettings
    {
        public string ConnectionURI { get; set; } = null!;
        public string DatabaseName { get; set; } = null!;
        public string CollectionName { get; set; } = null!;
        public BsonType GuidRepresentation { get; set; } = BsonType.String; // or BsonType.ObjectId

    }
}