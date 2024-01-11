using Microsoft.AspNetCore.Mvc;
using SecondHand.Application.Dtos;
using SecondHand.Application.Interfaces;
using SecondHand.Domain.Entities;

namespace SecondHand.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : CrudController<Customers, CustomersCreateDTO, CustomersUpdateDTO>
    {
        private readonly ICustomersService _customers;
        public CustomersController(ICustomersService customers) : base(customers)
        {
            _customers = customers;
        }
    }

}