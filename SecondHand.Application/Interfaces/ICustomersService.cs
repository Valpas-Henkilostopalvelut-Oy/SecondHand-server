using SecondHand.Application.Dtos;
using SecondHand.Domain.Entities;

namespace SecondHand.Application.Interfaces
{
    public interface ICustomersService : IBaseService<Customers, CustomersCreateDTO, CustomersUpdateDTO>
    {
    }
}