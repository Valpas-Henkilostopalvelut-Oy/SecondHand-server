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
        private IMongoCollection<Customers> _customers;

        public CustomerRepo(IOptions<MongoDBSettings> mongoDBSettings) : base(mongoDBSettings)
        {
            // Assign the _collection field from the base class to the _customers field
            _customers = _collection;
        }

        public async Task<Customers?> GetOneByEmail(string email)
        {
            FilterDefinition<Customers> filter = Builders<Customers>.Filter.Eq("Email", email);
            return await _customers.Find(filter).FirstOrDefaultAsync();
        }
    }
}