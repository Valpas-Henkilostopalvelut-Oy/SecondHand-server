using SecondHand.Domain.Entities;

namespace SecondHand.Domain.Interfaces
{
    public interface ICustomers : IBaseRepo<Customers>
    {
        Task<Customers?> GetOneByEmail(string email);
    }
}