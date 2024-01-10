using SecondHand.Application.Dtos;
using SecondHand.Domain.Entities;

namespace SecondHand.Application.Interfaces
{
    public interface IBusinessesService : IBaseService<Businesses, BusinessesReadDTO, BusinessesCreateDTO, BusinessesUpdateDTO>
    {
    }
}