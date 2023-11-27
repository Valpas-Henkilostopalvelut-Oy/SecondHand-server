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
    public class CustomerRepo : BaseRepo<Customers>, ICustomers
    {
        private readonly IMongoCollection<Customers> _customers;
        public CustomerRepo(IOptions<MongoDBSettings> mongoDBSettings) : base(mongoDBSettings)
        {
            MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
            IMongoDatabase database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
            _customers = database.GetCollection<Customers>(mongoDBSettings.Value.CollectionName);
        }

        public async Task<Customers?> GetOneByEmail(string email)
        {
            FilterDefinition<Customers> filter = Builders<Customers>.Filter.Eq("Email", email);
            return await _customers.Find(filter).FirstOrDefaultAsync();
        }
    }
}