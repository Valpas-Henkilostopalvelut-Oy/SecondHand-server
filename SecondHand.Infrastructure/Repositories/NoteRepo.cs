using Microsoft.Extensions.Options;
using MongoDB.Driver;
using SecondHand.Domain.Entities;
using SecondHand.Domain.Interfaces;
using SecondHand.Infrastructure.Models;

namespace SecondHand.Infrastructure.Repositories
{
    public class NoteRepo : BaseRepo<Notes>, INotes
    {
        private IMongoCollection<Notes> _notes;
        public NoteRepo(IOptions<MongoDBSettings> mongoDBSettings) : base(mongoDBSettings)
        {
            // Assign the _collection field from the base class to the _notes field
            _notes = _collection;
        }

    }
}