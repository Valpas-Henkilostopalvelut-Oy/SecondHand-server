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
    public class CustomersRepo : ICustomers
    {
        protected readonly IMongoCollection<Customers> _customers;
        public CustomersRepo(IOptions<MongoDBSettings> mongoDBSettings)
        {
            MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
            IMongoDatabase database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
            _customers = database.GetCollection<Customers>(typeof(Customers).Name);
        }

        public Task<Customers> Create(Customers entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Customers>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Customers?> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<Customers?> GetOneByEmail(string email)
        {
            FilterDefinition<Customers> filter = Builders<Customers>.Filter.Eq("Email", email);
            return await _customers.Find(filter).FirstOrDefaultAsync();
        }

        public Task<Customers> Update(Guid id, Customers updatedEntity)
        {
            throw new NotImplementedException();
        }
    }
}