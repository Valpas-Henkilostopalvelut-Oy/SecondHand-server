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
    public class NotesController : ControllerBase
    {
        private readonly INotesService _notes;
        public NotesController(INotesService notes)
        {
            _notes = notes;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _notes.GetAllAsync();
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _notes.GetByIdAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpGet("{id}/businesses")]
        public async Task<IActionResult> GetBusinesses(Guid id)
        {
            var result = await _notes.GetNotesOnBusinessAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpGet("{id}/customers")]
        public async Task<IActionResult> GetCustomers(Guid id)
        {
            var result = await _notes.GetNotesOnCustomerAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateNotesDTO notesDTO)
        {
            var result = await _notes.CreateAsync(notesDTO);
            if (result == null)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpPost("{id}/addBusiness")]
        public async Task<IActionResult> AddBusiness(Guid id, [FromBody] Guid businessId)
        {
            var result = await _notes.SetNoteOnBusinessAsync(id, businessId);
            if (result == null)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdateNotesDTO notesDTO)
        {
            var result = await _notes.UpdateAsync(id, notesDTO);
            if (result == null)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _notes.DeleteAsync(id);
            if (result == null)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
    }
}