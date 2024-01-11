using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using SecondHand.Domain.Entities;
using SecondHand.Domain.Interfaces;
using SecondHand.Infrastructure.Models;

namespace SecondHand.Infrastructure.Repositories
{
    public class CategoriesBusinessesRepo : ICategoriesBusinesses
    {
        protected readonly IMongoCollection<CategoriesBusinesses> _collection;
        public CategoriesBusinessesRepo(IOptions<MongoDBSettings> mongoDBSettings)
        {
            MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
            IMongoDatabase database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
            _collection = database.GetCollection<CategoriesBusinesses>(typeof(CategoriesBusinesses).Name);
        }

        public Task<CategoriesBusinesses> Create(CategoriesBusinesses entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CategoriesBusinesses>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<CategoriesBusinesses?> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<CategoriesBusinesses> Update(Guid id, CategoriesBusinesses updatedEntity)
        {
            throw new NotImplementedException();
        }
    }
}