using Microsoft.Extensions.Options;
using MongoDB.Driver;
using SecondHand.Domain.Entities;
using SecondHand.Domain.Interfaces;
using SecondHand.Infrastructure.Models;

namespace SecondHand.Infrastructure.Repositories
{
    public class CategoryRepo : BaseRepo<Categories>, ICategories
    {
        private IMongoCollection<Categories> _categories;
        public CategoryRepo(IOptions<MongoDBSettings> mongoDBSettings) : base(mongoDBSettings)
        {
            // Assign the _collection field from the base class to the _categories field
            _categories = _collection;
        }
    }
}