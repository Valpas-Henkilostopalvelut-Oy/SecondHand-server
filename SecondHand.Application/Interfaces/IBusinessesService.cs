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
        // get business locations
        Task<IEnumerable<Locations>> GetBusinessLocationsAsync(Guid businessId);
        // get business contacts
        Task<IEnumerable<Contacts>> GetBusinessContactsAsync(Guid businessId);
        // get business socials
        Task<Socials> GetBusinessSocialsAsync(Guid businessId);
        // get business opening hours
        Task<IEnumerable<OpeningHours>> GetBusinessOpeningHoursAsync(Guid businessId);
        // get business images
        Task<IEnumerable<Images>> GetBusinessImagesAsync(Guid businessId);
    }
}