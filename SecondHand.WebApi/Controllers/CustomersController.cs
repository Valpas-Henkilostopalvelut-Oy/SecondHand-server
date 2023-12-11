using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SecondHand.Application.Dtos;
using SecondHand.Application.Interfaces;
using SecondHand.Domain.Entities;

namespace SecondHand.Infrastructure.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    //[Authorize(Roles = "Admin")]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomersService _customers;
        public CustomersController(ICustomersService customers)
        {
            _customers = customers;
        }
        [HttpPost]
        public async Task<IActionResult> CreateCustomer([FromBody] CreateCustomersDTO customer)
        {
            var result = await _customers.CreateAsync(customer);
            if (result == null)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpPost("{id}/setAdmin")]
        public async Task<IActionResult> SetAdmin(Guid id)
        {
            var result = await _customers.ChangeUserRoleAsync(id, CustomerRole.Admin);
            if (result == null)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCustomers()
        {
            var result = await _customers.GetAllAsync();
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomerById(Guid id)
        {
            var result = await _customers.GetByIdAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpGet("{id}/businesses")]
        public async Task<IActionResult> GetCustomerBusinesses(Guid id)
        {
            var result = await _customers.GetOwnedBusinessesAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpGet("{id}/notes")]
        public async Task<IActionResult> GetCustomerNotes(Guid id)
        {
            var result = await _customers.GetOwnedNotesAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpGet("{id}/orders")]
        public async Task<IActionResult> GetCustomerOrders(Guid id)
        {
            var result = await _customers.GetOwnedOrdersAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCustomer(Guid id, [FromBody] UpdateCustomersDTO customer)
        {
            var result = await _customers.UpdateAsync(id, customer);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(Guid id)
        {
            var result = await _customers.DeleteAsync(id);
            if (result == null)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
    }
}