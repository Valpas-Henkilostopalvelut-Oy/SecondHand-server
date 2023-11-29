using Microsoft.Extensions.Options;
using MongoDB.Driver;
using SecondHand.Domain.Entities;
using SecondHand.Domain.Interfaces;
using SecondHand.Infrastructure.Models;

namespace SecondHand.Infrastructure.Repositories
{
    public class ImageRepo : BaseRepo<Images>, IImages
    {
        private IMongoCollection<Images> _images;
        public ImageRepo(IOptions<MongoDBSettings> mongoDBSettings) : base(mongoDBSettings)
        {
            // Assign the _collection field from the base class to the _images field
            _images = _collection;
        }
    }
}