using AutoMapper;
using SecondHand.Application.Dtos;
using SecondHand.Application.Interfaces;
using SecondHand.Domain.Entities;
using SecondHand.Domain.Interfaces;

namespace SecondHand.Application.Services
{
    public class BusinessesService : BaseService<Businesses, CreateBusinessesDTO, UpdateBusinessesDTO>, IBusinessesService
    {
        private readonly IBusinesses _repository;
        private readonly ICategories _categoriesRepository;
        public BusinessesService(IBusinesses repository, IMapper mapper, ICategories categories) : base(repository, mapper)
        {
            _repository = repository;
            _categoriesRepository = categories;
        }
        public async Task<IEnumerable<Categories>> GetBusinessCategoriesAsync(Guid businessId)
        {
            // many to many relationship between businesses and categories with table BusinessCategories
            var business = await _repository.GetById(businessId);
            if (business == null)
            {
                throw new Exception("Business not found");
            }
            return business.BusinessCategories!.Select(bc => bc.Category);
        }

        public async Task<IEnumerable<Contacts>> GetBusinessContactsAsync(Guid businessId)
        {
            var business = await _repository.GetById(businessId);
            if (business == null)
            {
                throw new Exception("Business not found");
            }
            return business.Contacts!;
        }

        public async Task<IEnumerable<Images>> GetBusinessImagesAsync(Guid businessId)
        {
            var business = await _repository.GetById(businessId);
            if (business == null)
            {
                throw new Exception("Business not found");
            }
            return null;
        }

        public async Task<IEnumerable<Locations>> GetBusinessLocationsAsync(Guid businessId)
        {
            var business = await _repository.GetById(businessId);
            if (business == null)
            {
                throw new Exception("Business not found");
            }
            return business.Locations!;
        }

        public async Task<IEnumerable<OpeningHours>> GetBusinessOpeningHoursAsync(Guid businessId)
        {
            var business = await _repository.GetById(businessId);
            if (business == null)
            {
                throw new Exception("Business not found");
            }
            return business.OpeningHours!;
        }

        public async Task<Socials> GetBusinessSocialsAsync(Guid businessId)
        {
            var business = await _repository.GetById(businessId);
            if (business == null)
            {
                throw new Exception("Business not found");
            }
            return business.Socials!;
        }

        public async Task<Businesses> SetBusinessCategoryAsync(Guid businessId, Guid categoryId)
        {
            // many to many relationship between businesses and categories with table BusinessCategories
            var business = await _repository.GetById(businessId);
            if (business == null)
            {
                throw new Exception("Business not found");
            }
            var category = await _categoriesRepository.GetById(categoryId);
            if (category == null)
            {
                throw new Exception("Category not found");
            }
            var businessCategory = new BusinessCategory
            {
                BusinessId = businessId,
                CategoryId = categoryId,
                Business = business,
                Category = category
            };
            if (business.BusinessCategories == null)
            {
                business.BusinessCategories = new List<BusinessCategory>();
            }
            else
            {
                business.BusinessCategories.Add(businessCategory);
            }
            if (category.BusinessCategories == null)
            {
                category.BusinessCategories = new List<BusinessCategory>();
            }
            else
            {
                category.BusinessCategories.Add(businessCategory);
            }
            var result = await _repository.Update(business);
            return result;
        }
    }
}