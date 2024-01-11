using AutoMapper;
using SecondHand.Application.Dtos;
using SecondHand.Application.Interfaces;
using SecondHand.Domain.Entities;
using SecondHand.Domain.Interfaces;

namespace SecondHand.Application.Services
{
    public class CustomersService : ICustomersService
    {
        private readonly ICustomers _customers;
        private readonly IMapper _mapper;
        public CustomersService(ICustomers customers, IMapper mapper)
        {
            _customers = customers;
            _mapper = mapper;
        }

        public Task<Customers> CreateOne(CustomersCreateDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteOneById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Customers>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Customers> GetOneById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Customers> UpdateOneById(Guid id, CustomersUpdateDTO updated)
        {
            throw new NotImplementedException();
        }

    }
}