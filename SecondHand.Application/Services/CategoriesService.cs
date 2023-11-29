using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SecondHand.Application.Dtos;
using SecondHand.Application.Interfaces;
using SecondHand.Domain.Entities;
using SecondHand.Domain.Interfaces;

namespace SecondHand.Application.Services
{
    public class CategoriesService : BaseService<Categories, CreateCategoriesDTO, UpdateCategoriesDTO>, ICategoriesService
    {
        private readonly ICategories _categories;
        private readonly IBusinesses _businesses;
        public CategoriesService(ICategories categories, IMapper mapper, IBusinesses businesses) : base(categories, mapper)
        {
            _categories = categories;
            _businesses = businesses;
        }
        public async Task<IEnumerable<Businesses>> GetBusinessesOnCategoryAsync(Guid categoryId)
        {
            var category = await _categories.GetById(categoryId);
            if (category == null)
            {
                throw new Exception("Category not found");
            }
            var businesses = await _businesses.GetAll();
            return businesses.Where(x => x.Categories != null && x.Categories.Any(b => b.Id == categoryId));
        }

        public async Task<ResultDTO> SetBusinessesOnCategoryAsync(Guid categoryId, Guid businessId)
        {
            var category = await _categories.GetById(categoryId);
            if (category == null)
            {
                throw new Exception("Category not found");
            }
            var business = await _businesses.GetById(businessId);
            if (business == null)
            {
                throw new Exception("Business not found");
            }
            category.Businesses!.Add(business);
            var result = await _categories.Update(category);
            var resultMapped = _mapper.Map<ResultDTO>(result);
            return resultMapped;
        }

        public async Task<ResultDTO> SetCategoryImageAsync(Guid categoryId, string imageUrl)
        {
            var category = await _categories.GetById(categoryId);
            if (category == null)
            {
                throw new Exception("Category not found");
            }
            category.Image = imageUrl;
            var result = await _categories.Update(category);
            var resultMapped = _mapper.Map<ResultDTO>(result);
            return resultMapped;
        }
    }
}