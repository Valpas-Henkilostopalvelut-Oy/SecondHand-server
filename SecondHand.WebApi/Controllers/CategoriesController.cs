using Microsoft.AspNetCore.Mvc;
using SecondHand.Application.Dtos;
using SecondHand.Application.Interfaces;
using SecondHand.Domain.Entities;

namespace SecondHand.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : CrudController<Categories, CategoriesCreateDTO, CategoriesUpdateDTO>
    {
        private readonly ICategoriesService _categories;
        public CategoriesController(ICategoriesService categories) : base(categories)
        {
            _categories = categories;
        }
    }
}