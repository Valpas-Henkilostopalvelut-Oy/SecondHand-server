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
    public class ContactRepo : BaseRepo<Contacts>, IContacts
    {
        private IMongoCollection<Contacts> _contacts;
        public ContactRepo(IOptions<MongoDBSettings> mongoDBSettings) : base(mongoDBSettings)
        {
            // Assign the _collection field from the base class to the _contacts field
            _contacts = _collection;
        }
    }
}