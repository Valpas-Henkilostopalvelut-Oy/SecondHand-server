using AutoMapper;
using SecondHand.Application.Dtos;
using SecondHand.Application.Interfaces;
using SecondHand.Domain.Entities;
using SecondHand.Domain.Interfaces;

namespace SecondHand.Application.Services
{
    public class CustomersService : BaseService<Customers, CustomersReadDTO, CustomersCreateDTO, CustomersUpdateDTO>, ICustomersService
    {
        private readonly ICustomers _customers;
        public CustomersService(ICustomers customers, IMapper mapper) : base(customers, mapper)
        {
            _customers = customers;
        }

    }
}