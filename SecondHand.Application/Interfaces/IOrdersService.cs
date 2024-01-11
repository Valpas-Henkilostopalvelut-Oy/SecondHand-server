using SecondHand.Application.Dtos;
using SecondHand.Domain.Entities;

namespace SecondHand.Application.Interfaces
{
    public interface IOrdersService : IBaseService<Orders, OrdersCreateDTO, OrdersUpdateDTO>
    {
    }
}