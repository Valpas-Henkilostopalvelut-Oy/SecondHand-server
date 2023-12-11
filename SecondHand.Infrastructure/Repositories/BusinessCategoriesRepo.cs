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
    public class BusinessCategoriesRepo : BaseRepo<BusinessCategory>, IBaseEntity<BusinessCategory>
    {
        private IMongoCollection<BusinessCategory> _businessCategories;
        public BusinessCategoriesRepo(IOptions<MongoDBSettings> mongoDBSettings) : base(mongoDBSettings)
        {
            // Assign the _collection field from the base class to the _businessCategories field
            _businessCategories = _collection;
        }
    }
}