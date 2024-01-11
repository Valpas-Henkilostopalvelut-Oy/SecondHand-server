using Microsoft.AspNetCore.Mvc;
using SecondHand.Application.Dtos;
using SecondHand.Application.Interfaces;
using SecondHand.Domain.Entities;

namespace SecondHand.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LocationsController : CrudController<Locations, LocationsCreateDTO, LocationsUpdateDTO>
    {
        private readonly ILocationsService _locations;
        public LocationsController(ILocationsService locations) : base(locations)
        {
            _locations = locations;
        }
    }
}