using SecondHand.Domain.Entities;

namespace SecondHand.Domain.Interfaces
{
    public interface ICustomers : IBaseEntity<Customers>
    {
        Task<Customers?> GetOneByEmail(string email);
    }
}