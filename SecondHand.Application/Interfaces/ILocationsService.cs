
using SecondHand.Application.Dtos;
using SecondHand.Domain.Entities;

namespace SecondHand.Application.Interfaces
{
    public interface ILocationsService : IBaseService<Locations, LocationsCreateDTO, LocationsUpdateDTO>
    {

    }
}