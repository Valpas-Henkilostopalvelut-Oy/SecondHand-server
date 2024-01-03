using SecondHand.Application.Dtos;
using SecondHand.Domain.Entities;

namespace SecondHand.Application.Interfaces
{
    public interface IBusinessesService : IBaseService<Businesses, CreateBusinessesDTO, UpdateBusinessesDTO, ResultDTO>
    {
        // Get business categories
        Task<IEnumerable<Categories>> GetBusinessCategoriesAsync(Guid businessId);
        // Set business category
        Task<Businesses> SetBusinessCategoryAsync(Guid businessId, Guid categoryId);
        // get business images
        Task<IEnumerable<Images>> GetBusinessImagesAsync(Guid businessId);
        // Update business opening hours from google maps
        Task<Businesses> UpdateBusinessOpeningHoursAsync(UpdateHours updateHours);
    }
}