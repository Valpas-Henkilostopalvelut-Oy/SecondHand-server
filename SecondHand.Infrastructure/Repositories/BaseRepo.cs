using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SecondHand.Domain.Interfaces;

namespace SecondHand.Infrastructure.Repositories
{
    public class BaseRepo<T> : IBaseRepo<T> where T : class
    {
        public Task<T> CreateOne(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteOneById(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<T?> GetOneById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateOne(T updatedEntity)
        {
            throw new NotImplementedException();
        }
    }
}