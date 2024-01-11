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
    public class OrdersRepo : IOrders
    {
        protected readonly IMongoCollection<Orders> _collection;
        public OrdersRepo(IOptions<MongoDBSettings> mongoDBSettings)
        {
            MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
            IMongoDatabase database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
            _collection = database.GetCollection<Orders>(typeof(Orders).Name);
        }

        public Task<Orders> Create(Orders entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Orders>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Orders?> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Orders> Update(Guid id, Orders updatedEntity)
        {
            throw new NotImplementedException();
        }
    }
}