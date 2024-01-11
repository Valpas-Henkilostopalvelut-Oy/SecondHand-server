using Microsoft.Extensions.Options;
using MongoDB.Driver;
using SecondHand.Domain.Entities;
using SecondHand.Domain.Interfaces;
using SecondHand.Infrastructure.Models;

namespace SecondHand.Infrastructure.Repositories
{
    public class LocationBusinessesRepo : ILocationBusinesses
    {
        protected readonly IMongoCollection<LocationBusinesses> _collection;
        public LocationBusinessesRepo(IOptions<MongoDBSettings> mongoDBSettings)
        {
            MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
            IMongoDatabase database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
            _collection = database.GetCollection<LocationBusinesses>(typeof(LocationBusinesses).Name);
        }

        public Task<LocationBusinesses> Create(LocationBusinesses entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<LocationBusinesses>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<LocationBusinesses?> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<LocationBusinesses> Update(Guid id, LocationBusinesses updatedEntity)
        {
            throw new NotImplementedException();
        }
    }
}