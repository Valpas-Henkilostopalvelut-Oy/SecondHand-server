using Microsoft.Extensions.Options;
using MongoDB.Driver;
using SecondHand.Domain.Entities;
using SecondHand.Domain.Interfaces;
using SecondHand.Infrastructure.Models;

namespace SecondHand.Infrastructure.Repositories
{
    public class LocationRepo : BaseRepo<Locations>, ILocations
    {
        private IMongoCollection<Locations> _locations;
        public LocationRepo(IOptions<MongoDBSettings> mongoDBSettings) : base(mongoDBSettings)
        {
            // Assign the _collection field from the base class to the _locations field
            _locations = _collection;
        }

    }
}