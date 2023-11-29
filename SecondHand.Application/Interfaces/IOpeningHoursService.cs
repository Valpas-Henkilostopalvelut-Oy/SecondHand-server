using SecondHand.Application.Dtos;
using SecondHand.Domain.Entities;

namespace SecondHand.Application.Interfaces
{
    public interface IOpeningHoursService : IBaseService<OpeningHours, CreateOpeningHoursDTO, UpdateOpeningHoursDTO, ResultDTO>
    {
        // Get OpeningHours on Business
        Task<IEnumerable<OpeningHours>> GetOpeningHoursOnBusinessAsync(Guid businessId);
        // Set OpeningHours on Business
        Task<ResultDTO> SetOpeningHoursOnBusinessAsync(Guid businessId, Guid openingHoursId);
    }
}