using Microsoft.Extensions.Options;
using MongoDB.Driver;
using SecondHand.Domain.Interfaces;
using SecondHand.Infrastructure.Models;

namespace SecondHand.Infrastructure.Repositories
{
    public class BaseRepo<T> : IBaseEntity<T> where T : class
    {
        protected readonly IMongoCollection<T> _collection;
        public BaseRepo(IOptions<MongoDBSettings> mongoDBSettings)
        {
            MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
            IMongoDatabase database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
            _collection = database.GetCollection<T>(typeof(T).Name);
        }

        public async Task<T> Create(T entity)
        {
            await _collection.InsertOneAsync(entity);
            return entity;
        }

        public async Task<bool> SetDeleted(T entity)
        {
            FilterDefinition<T> filter = Builders<T>.Filter.Eq("Id", entity);
            UpdateDefinition<T> update = Builders<T>.Update.Set("IsDeleted", true);
            UpdateResult result = await _collection.UpdateOneAsync(filter, update);
            return result.IsAcknowledged && result.ModifiedCount > 0;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _collection.Find(_ => true).ToListAsync();
        }

        public async Task<T?> GetById(Guid id)
        {
            FilterDefinition<T> filter = Builders<T>.Filter.Eq("Id", id);
            return await _collection.Find(filter).FirstOrDefaultAsync();
        }

        public async Task<T> Update(T updatedEntity)
        {
            FilterDefinition<T> filter = Builders<T>.Filter.Eq("Id", updatedEntity);
            await _collection.ReplaceOneAsync(filter, updatedEntity);
            return updatedEntity;
        }
    }
}