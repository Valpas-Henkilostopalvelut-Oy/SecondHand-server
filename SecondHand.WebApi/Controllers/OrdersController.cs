using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SecondHand.Application.Dtos;
using SecondHand.Application.Interfaces;
using SecondHand.Domain.Entities;

namespace SecondHand.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : CrudController<Orders, OrdersCreateDTO, OrdersUpdateDTO>
    {
        private readonly IOrdersService _orders;
        public OrdersController(IOrdersService orders) : base(orders)
        {
            _orders = orders;
        }

    }
}