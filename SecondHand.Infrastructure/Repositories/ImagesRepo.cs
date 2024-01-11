using Microsoft.Extensions.Options;
using MongoDB.Driver;
using SecondHand.Domain.Entities;
using SecondHand.Domain.Interfaces;
using SecondHand.Infrastructure.Models;

namespace SecondHand.Infrastructure.Repositories
{
    public class ImagesRepo : IImages
    {
        protected readonly IMongoCollection<Images> _collection;
        public ImagesRepo(IOptions<MongoDBSettings> mongoDBSettings)
        {
            MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
            IMongoDatabase database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
            _collection = database.GetCollection<Images>(typeof(Images).Name);
        }


        public Task<Images> Create(Images entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Images>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Images?> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Images> Update(Guid id, Images updatedEntity)
        {
            throw new NotImplementedException();
        }
    }
}