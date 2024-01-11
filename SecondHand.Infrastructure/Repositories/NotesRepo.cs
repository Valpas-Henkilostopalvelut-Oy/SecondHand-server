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
    public class NotesRepo : INotes
    {
        protected readonly IMongoCollection<Notes> _collection;
        public NotesRepo(IOptions<MongoDBSettings> mongoDBSettings)
        {
            MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
            IMongoDatabase database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
            _collection = database.GetCollection<Notes>(typeof(Notes).Name);
        }

        public Task<Notes> Create(Notes entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Notes>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Notes?> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Notes> Update(Guid id, Notes updatedEntity)
        {
            throw new NotImplementedException();
        }
    }
}