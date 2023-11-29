using AutoMapper;
using SecondHand.Application.Dtos;
using SecondHand.Application.Interfaces;
using SecondHand.Domain.Entities;
using SecondHand.Domain.Interfaces;

namespace SecondHand.Application.Services
{
    public class CustomersService : BaseService<Customers, CreateCustomersDTO, UpdateCustomersDTO>, ICustomersService
    {
        private readonly ICustomers _customers;
        public CustomersService(ICustomers customers, IMapper mapper) : base(customers, mapper)
        {
            _customers = customers;
        }
        public async Task<ResultDTO> ChangeUserRoleAsync(Guid customerId, CustomerRole role)
        {
            var customer = await _customers.GetById(customerId);
            if (customer == null)
            {
                throw new Exception("Customer not found");
            }
            customer.Role = role;
            var result = await _customers.Update(customer);
            var resultMapped = _mapper.Map<ResultDTO>(result);
            return resultMapped;
        }

        public async Task<IEnumerable<Businesses>> GetOwnedBusinessesAsync(Guid customerId)
        {
            var customer = await _customers.GetById(customerId);
            if (customer == null)
            {
                throw new Exception("Customer not found");
            }
            return customer.Businesses!;
        }

        public async Task<IEnumerable<Notes>> GetOwnedNotesAsync(Guid customerId)
        {
            var customer = await _customers.GetById(customerId);
            if (customer == null)
            {
                throw new Exception("Customer not found");
            }
            return customer.Notes!;
        }

        public async Task<IEnumerable<Orders>> GetOwnedOrdersAsync(Guid customerId)
        {
            var customer = await _customers.GetById(customerId);
            if (customer == null)
            {
                throw new Exception("Customer not found");
            }
            return customer.Orders!;
        }
    }
}