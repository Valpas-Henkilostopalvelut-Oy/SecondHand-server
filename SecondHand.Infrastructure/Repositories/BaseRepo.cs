using Microsoft.Extensions.Options;
using MongoDB.Driver;
using SecondHand.Domain.Interfaces;
using SecondHand.Infrastructure.Models;

namespace SecondHand.Infrastructure.Repositories
{
    public class BaseRepo<T> : IBaseEntity<T> where T : class
    {
        private readonly IMongoCollection<T> _collection;
        public BaseRepo(IOptions<MongoDBSettings> mongoDBSettings)
        {
            MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
            IMongoDatabase database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
            _collection = database.GetCollection<T>(mongoDBSettings.Value.CollectionName);
        }

        public async Task<T> Create(T entity)
        {
            await _collection.InsertOneAsync(entity);
            return entity;
        }

        public async Task<bool> Delete(T entity)
        {
            FilterDefinition<T> filter = Builders<T>.Filter.Eq("Id", entity);
            DeleteResult deleteResult = await _collection.DeleteOneAsync(filter);
            return deleteResult.IsAcknowledged && deleteResult.DeletedCount > 0;
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