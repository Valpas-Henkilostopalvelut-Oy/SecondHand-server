using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SecondHand.Application.Dtos;
using SecondHand.Application.Interfaces;
using SecondHand.Domain.Interfaces;

namespace SecondHand.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BusinessesController : ControllerBase
    {
        private readonly IBusinessesService _businesses;
        public BusinessesController(IBusinessesService businesses)
        {
            _businesses = businesses;
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateBusinessesDTO request)
        {
            var result = await _businesses.CreateAsync(request);
            if (result == null)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _businesses.GetAllAsync();
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _businesses.GetByIdAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpGet("{id}/openinghours")]
        public async Task<IActionResult> GetOpeningHours(Guid id)
        {
            var result = await _businesses.GetBusinessOpeningHoursAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpGet("{id}/contacts")]
        public async Task<IActionResult> GetContacts(Guid id)
        {
            var result = await _businesses.GetBusinessContactsAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpGet("{id}/locations")]
        public async Task<IActionResult> GetLocations(Guid id)
        {
            var result = await _businesses.GetBusinessLocationsAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpGet("{id}/categories")]
        public async Task<IActionResult> GetCategories(Guid id)
        {
            var result = await _businesses.GetBusinessCategoriesAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpPost("{id}/categories/{categoryId}")]
        public async Task<IActionResult> SetCategory(Guid id, Guid categoryId)
        {
            var result = await _businesses.SetBusinessCategoryAsync(id, categoryId);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpGet("{id}/images")]
        public async Task<IActionResult> GetImages(Guid id)
        {
            var result = await _businesses.GetBusinessImagesAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpGet("{id}/socials")]
        public async Task<IActionResult> GetSocials(Guid id)
        {
            var result = await _businesses.GetBusinessSocialsAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdateBusinessesDTO request)
        {
            var result = await _businesses.UpdateAsync(id, request);
            if (result != null)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _businesses.DeleteAsync(id);
            if (result == null)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

    }
}