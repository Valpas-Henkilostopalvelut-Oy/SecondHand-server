using AutoMapper;
using SecondHand.Application.Dtos;
using SecondHand.Application.Interfaces;
using SecondHand.Domain.Entities;
using SecondHand.Domain.Interfaces;

namespace SecondHand.Application.Services
{
    public class BusinessesServices : BaseServices<Businesses, CreateBusinessesDTO, UpdateBusinessesDTO>, IBusinessesServices
    {
        private readonly IBaseEntity<Businesses> _repository;
        private readonly IBaseEntity<Categories> _categoriesRepository;
        public BusinessesServices(IBaseEntity<Businesses> repository, IMapper mapper, IBaseEntity<Categories> categories) : base(repository, mapper)
        {
            _repository = repository;
            _categoriesRepository = categories;
        }
        public async Task<IEnumerable<Categories>> GetBusinessCategoriesAsync(Guid businessId)
        {
            var business = await _repository.GetById(businessId);
            if (business == null)
            {
                throw new Exception("Business not found");
            }
            var categories = await _categoriesRepository.GetAll();
            return categories.Where(x => x.Businesses != null && x.Businesses.Any(b => b.Id == businessId));
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
            business.Categories!.Add(category);
            await _repository.Update(business);
            return business;
        }
    }
}