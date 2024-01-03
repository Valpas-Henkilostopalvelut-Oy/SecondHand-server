using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using AutoMapper;
using SecondHand.Application.CustomException;
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
        private readonly HttpClient _httpClient;


        public BusinessesService(IBusinesses repository, IMapper mapper, ICategories categories, HttpClient httpClient) : base(repository, mapper)
        {
            _repository = repository;
            _categoriesRepository = categories;
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Categories>> GetBusinessCategoriesAsync(Guid businessId)
        {
            var business = await _repository.GetById(businessId);
            if (business == null)
            {
                throw new BusinessNotFoundException($"Business with ID {businessId} not found");
            }
            return business.Categories ?? Enumerable.Empty<Categories>();
        }

        public async Task<IEnumerable<Images>> GetBusinessImagesAsync(Guid businessId)
        {
            var business = await _repository.GetById(businessId);
            if (business == null)
            {
                throw new BusinessNotFoundException($"Business with ID {businessId} not found");
            }

            return null ?? Enumerable.Empty<Images>();
        }

        public async Task<Businesses> SetBusinessCategoryAsync(Guid businessId, Guid categoryId)
        {
            var business = await _repository.GetById(businessId);
            if (business == null)
            {
                throw new BusinessNotFoundException($"Business with ID {businessId} not found");
            }
            var category = await _categoriesRepository.GetById(categoryId);
            if (category == null)
            {
                throw new CategoryNotFoundException($"Category with ID {categoryId} not found");
            }

            business.Categories ??= new List<Categories>();
            if (!business.Categories.Contains(category))
            {
                business.Categories.Add(category);
            }

            var result = await _repository.Update(business);
            return result;
        }

        public async Task<Businesses> UpdateBusinessOpeningHoursAsync(UpdateHours updateHours)
        {
            var business = await _repository.GetById(updateHours.Id);
            if (business == null)
            {
                throw new BusinessNotFoundException($"Business with ID {updateHours.Id} not found");
            }

            var requestBody = new
            {
                textQuery = updateHours.TextQuery,
            };
            var requestContent = new StringContent(JsonSerializer.Serialize(requestBody), Encoding.UTF8, "application/json");
            _httpClient.DefaultRequestHeaders.Add("X-Goog-Api-Key", "AIzaSyBv_2Gvrz1EsLdA19REeX8jnZx0PA3ZGDY");
            _httpClient.DefaultRequestHeaders.Add("X-Goog-FieldMask", "*");
            var response = await _httpClient.PostAsync("https://places.googleapis.com/v1/places:searchText", requestContent);
            if (!response.IsSuccessStatusCode)
            {
                throw new GoogleMapsApiException($"Google Maps API returned bad status code: {response.StatusCode}");
            }

            var responseContent = await response.Content.ReadAsStringAsync();
            var responseData = JsonSerializer.Deserialize<YourResponseType>(responseContent);



            // Предполагается, что responseData.places[0].regularOpeningHours содержит корректные данные
            var regularOpeningHours = responseData.places[0].regularOpeningHours;
            business.OpeningHours = regularOpeningHours;

            var result = await _repository.Update(business);

            var resultMapped = _mapper.Map<Businesses>(result);
            return resultMapped;
        }
    }

    internal class YourResponseType
    {
        public List<Places> places { get; set; }
    }

    public class Places
    {
        public string name { get; set; }
        public string formattedAddress { get; set; }
        public OpeningHours regularOpeningHours { get; set; }
    }
}
