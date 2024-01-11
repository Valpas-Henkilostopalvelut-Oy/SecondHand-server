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
    public class LocationsRepo : ILocations
    {
        protected readonly IMongoCollection<Locations> _collection;
        public LocationsRepo(IOptions<MongoDBSettings> mongoDBSettings)
        {
            MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
            IMongoDatabase database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
            _collection = database.GetCollection<Locations>(typeof(Locations).Name);
        }

        public Task<Locations> Create(Locations entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Locations>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Locations?> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Locations> Update(Guid id, Locations updatedEntity)
        {
            throw new NotImplementedException();
        }
    }
}