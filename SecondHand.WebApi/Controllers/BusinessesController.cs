using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SecondHand.Application.Dtos;
using SecondHand.Application.Interfaces;


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
        [HttpPost("/update-hours")]
        public async Task<IActionResult> UpdateBusinessOpeningHoursAsync(UpdateHours updateHours)
        {
            var result = await _businesses.UpdateBusinessOpeningHoursAsync(updateHours);
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
        [Authorize]
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
        [Authorize]
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