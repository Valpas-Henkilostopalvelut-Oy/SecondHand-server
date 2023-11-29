using SecondHand.Application.Dtos;
using SecondHand.Domain.Entities;

namespace SecondHand.Application.Interfaces
{
    public interface ILocationsService : IBaseService<Locations, CreateLocationsDTO, UpdateLocationsDTO, ResultDTO>
    {
        // Get all businesses on location
        Task<IEnumerable<Businesses>> GetBusinessesOnLocationAsync(Guid locationId);
        // Set business on location
        Task<ResultDTO> SetBusinessOnLocationAsync(Guid locationId, Guid businessId);
    }
}