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
    public class TypesRepo : ITypes
    {
        protected readonly IMongoCollection<Types> _collection;
        public TypesRepo(IOptions<MongoDBSettings> mongoDBSettings)
        {
            MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
            IMongoDatabase database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
            _collection = database.GetCollection<Types>(typeof(Types).Name);
        }

        public Task<Types> Create(Types entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Types>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Types?> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Types> Update(Guid id, Types updatedEntity)
        {
            throw new NotImplementedException();
        }
    }
}