using Microsoft.Extensions.Options;
using MongoDB.Driver;
using SecondHand.Application.Dtos;
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

        public async Task<Businesses> Create(Businesses entity)
        {
            // TODO: Return created entity
            return await _collection.InsertOneAsync(entity).ContinueWith(task => entity);
        }

        public async Task<IEnumerable<Businesses>> GetAll()
        {
            // TODO: Return all entities
            return await _collection.Find(_ => true).ToListAsync();
        }

        public async Task<Businesses?> GetById(Guid id)
        {
            return await _collection.Find(entity => entity.Id == id).FirstOrDefaultAsync();
        }

        public Task<Businesses> Update(Guid id, Businesses updatedEntity)
        {
            throw new NotImplementedException();
        }
    }
}