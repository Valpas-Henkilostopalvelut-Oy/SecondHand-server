using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SecondHand.Application.Dtos;
using SecondHand.Application.Interfaces;

namespace SecondHand.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LocationsController : ControllerBase
    {
        private readonly ILocationsService _locations;
        public LocationsController(ILocationsService locations)
        {
            _locations = locations;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _locations.GetAllAsync();
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _locations.GetByIdAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpGet("{id}/businesses")]
        public async Task<IActionResult> GetBusinesses(Guid id)
        {
            var result = await _locations.GetBusinessesOnLocationAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateLocationsDTO locationsDTO)
        {
            var result = await _locations.CreateAsync(locationsDTO);
            if (result == null)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpPost("{id}/addBusiness")]
        public async Task<IActionResult> AddBusiness(Guid id, [FromBody] Guid businessId)
        {
            var result = await _locations.SetBusinessOnLocationAsync(id, businessId);
            if (result == null)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdateLocationsDTO locationsDTO)
        {
            var result = await _locations.UpdateAsync(id, locationsDTO);
            if (result == null)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _locations.DeleteAsync(id);
            if (result == null)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

    }
}