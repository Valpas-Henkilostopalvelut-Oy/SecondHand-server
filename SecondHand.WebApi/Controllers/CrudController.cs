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
    [Route("api/[controller]s")]
    public class CrudController<T, TCreateDto, TUpdateDto> : ControllerBase
    {
        private readonly IBaseService<T, TCreateDto, TUpdateDto> _entity;
        public CrudController(IBaseService<T, TCreateDto, TUpdateDto> entity)
        {
            _entity = entity;
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TCreateDto request)
        {
            var result = await _entity.CreateOne(request);
            if (result == null)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _entity.GetAll();
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _entity.GetOneById(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] TUpdateDto request)
        {
            var result = await _entity.UpdateOneById(id, request);
            if (result == null)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _entity.DeleteOneById(id);
            if (result == null)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
    }
}