using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SecondHand.Application.CustomException;
using SecondHand.Application.Dtos;
using SecondHand.Application.Interfaces;
using SecondHand.Domain.Entities;
using SecondHand.Domain.Interfaces;

namespace SecondHand.Application.Services
{
    public class CategoriesService : ICategoriesService
    {
        private readonly ICategories _categories;
        private readonly IMapper _mapper;
        public CategoriesService(ICategories categories, IMapper mapper)
        {
            _categories = categories;
            _mapper = mapper;
        }

        public Task<Categories> CreateOne(CategoriesCreateDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteOneById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Categories>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Categories> GetOneById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Categories> UpdateOneById(Guid id, CategoriesUpdateDTO updated)
        {
            throw new NotImplementedException();
        }
    }
}