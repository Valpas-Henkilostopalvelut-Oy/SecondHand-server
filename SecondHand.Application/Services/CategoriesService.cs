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
    public class CategoriesService : BaseService<Categories, CategoriesReadDTO, CategoriesCreateDTO, CategoriesUpdateDTO>, ICategoriesService
    {
        private readonly ICategories _categories;
        public CategoriesService(ICategories categories, IMapper mapper) : base(categories, mapper)
        {
            _categories = categories;
        }

    }
}