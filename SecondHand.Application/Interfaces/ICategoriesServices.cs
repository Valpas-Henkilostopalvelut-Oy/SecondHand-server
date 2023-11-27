using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SecondHand.Application.Dtos;
using SecondHand.Domain.Entities;

namespace SecondHand.Application.Interfaces
{
    public interface ICategoriesServices : IBaseServices<Categories, CreateCategoriesDTO, UpdateCategoriesDTO>
    {
        // Get Businesses on Category
        Task<IEnumerable<Businesses>> GetBusinessesOnCategoryAsync(Guid categoryId);
        // Set Businesses on Category
        Task<ResultDTO> SetBusinessesOnCategoryAsync(Guid categoryId, Guid businessId);
    }
}