using Microsoft.Extensions.Options;
using MongoDB.Driver;
using SecondHand.Domain.Entities;
using SecondHand.Domain.Interfaces;
using SecondHand.Infrastructure.Models;

namespace SecondHand.Infrastructure.Repositories
{
    public class CategoriesRepo : ICategories
    {
        protected readonly IMongoCollection<Categories> _collection;
        public CategoriesRepo(IOptions<MongoDBSettings> mongoDBSettings)
        {
            MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
            IMongoDatabase database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
            _collection = database.GetCollection<Categories>(typeof(Categories).Name);
        }

        public Task<Categories> Create(Categories entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Categories>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Categories?> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Categories> Update(Guid id, Categories updatedEntity)
        {
            throw new NotImplementedException();
        }
    }
}