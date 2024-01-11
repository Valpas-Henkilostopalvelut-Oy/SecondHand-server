using Microsoft.Extensions.Options;
using MongoDB.Driver;
using SecondHand.Domain.Entities;
using SecondHand.Domain.Interfaces;
using SecondHand.Infrastructure.Models;

namespace SecondHand.Infrastructure.Repositories
{
    public class BusinessesRepo : IBusinesses
    {
        protected readonly IMongoCollection<Businesses> _collection;
        public BusinessesRepo(IOptions<MongoDBSettings> mongoDBSettings)
        {
            MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
            IMongoDatabase database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
            _collection = database.GetCollection<Businesses>(typeof(Businesses).Name);
        }

        public Task<Businesses> Create(Businesses entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Businesses>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Businesses?> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Businesses> Update(Guid id, Businesses updatedEntity)
        {
            throw new NotImplementedException();
        }
    }
}