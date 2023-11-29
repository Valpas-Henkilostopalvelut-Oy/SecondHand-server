using SecondHand.Application.Dtos;
using SecondHand.Domain.Entities;

namespace SecondHand.Application.Interfaces
{
    public interface ICustomersService : IBaseService<Customers, CreateCustomersDTO, UpdateCustomersDTO, ResultDTO>
    {
        // Get all owned businesses
        Task<IEnumerable<Businesses>> GetOwnedBusinessesAsync(Guid customerId);
        // Get all own notes
        Task<IEnumerable<Notes>> GetOwnedNotesAsync(Guid customerId);
        // Get all own orders
        Task<IEnumerable<Orders>> GetOwnedOrdersAsync(Guid customerId);
        // Change user role
        Task<ResultDTO> ChangeUserRoleAsync(Guid customerId, CustomerRole role);
    }
}