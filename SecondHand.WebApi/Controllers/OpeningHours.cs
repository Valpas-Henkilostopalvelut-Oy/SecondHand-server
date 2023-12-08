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
    public class OpeningHours : ControllerBase
    {
        private readonly IOpeningHoursService _openingHours;
        public OpeningHours(IOpeningHoursService openingHours)
        {
            _openingHours = openingHours;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _openingHours.GetAllAsync();
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _openingHours.GetByIdAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpGet("{id}/businesses")]
        public async Task<IActionResult> GetBusinesses(Guid id)
        {
            var result = await _openingHours.GetOpeningHoursOnBusinessAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateOpeningHoursDTO openingHoursDTO)
        {
            var result = await _openingHours.CreateAsync(openingHoursDTO);
            if (result == null)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpPost("{id}/addBusiness")]
        public async Task<IActionResult> AddBusiness(Guid id, [FromBody] Guid businessId)
        {
            var result = await _openingHours.SetOpeningHoursOnBusinessAsync(id, businessId);
            if (result == null)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdateOpeningHoursDTO openingHoursDTO)
        {
            var result = await _openingHours.UpdateAsync(id, openingHoursDTO);
            if (result == null)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _openingHours.DeleteAsync(id);
            if (result == null)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
    }
}