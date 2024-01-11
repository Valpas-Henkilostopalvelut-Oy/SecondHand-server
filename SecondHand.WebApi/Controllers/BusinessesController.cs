using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SecondHand.Application.Dtos;
using SecondHand.Application.Interfaces;
using SecondHand.Domain.Entities;


namespace SecondHand.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BusinessesController : CrudController<Businesses, BusinessesCreateDTO, BusinessesUpdateDTO>
    {
        private readonly IBusinessesService _businesses;
        public BusinessesController(IBusinessesService businesses) : base(businesses)
        {
            _businesses = businesses;
        }
    }
}