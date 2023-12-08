using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SecondHand.Application.Dtos;
using SecondHand.Application.Interfaces;

namespace SecondHand.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoriesService _categories;
        public CategoriesController(ICategoriesService categories)
        {
            _categories = categories;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _categories.GetAllAsync();
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _categories.GetByIdAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpGet("{id}/businesses")]
        public async Task<IActionResult> GetBusinesses(Guid id)
        {
            var result = await _categories.GetBusinessesOnCategoryAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpPost]
        
        public async Task<IActionResult> Create([FromBody] CreateCategoriesDTO name)
        {
            var result = await _categories.CreateAsync(name);
            if (result == null)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpPost("{id}/addBusiness")]
        
        public async Task<IActionResult> AddBusiness(Guid id, [FromBody] Guid businessId)
        {
            var result = await _categories.SetBusinessesOnCategoryAsync(id, businessId);
            if (result == null)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpPost("{id}/removeBusiness")]
        
        public async Task<IActionResult> RemoveBusiness(Guid id, [FromBody] Guid businessId)
        {
            var result = await _categories.RemoveBusinessesOnCategoryAsync(id, businessId);
            if (result == null)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpPost("{id}/setImage")]
        
        public async Task<IActionResult> SetImage(Guid id, [FromBody] string imageUrl)
        {
            var result = await _categories.SetCategoryImageAsync(id, imageUrl);
            if (result == null)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpPut("{id}")]
        
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdateCategoriesDTO name)
        {
            var result = await _categories.UpdateAsync(id, name);
            if (result == null)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpDelete("{id}")]
        
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _categories.DeleteAsync(id);
            if (result == null)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
    }
}