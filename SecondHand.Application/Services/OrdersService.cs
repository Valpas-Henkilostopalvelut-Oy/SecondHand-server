using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SecondHand.Application.Dtos;
using SecondHand.Application.Interfaces;
using SecondHand.Domain.Entities;
using SecondHand.Domain.Interfaces;

namespace SecondHand.Application.Services
{
    public class OrdersService : BaseService<Orders, CreateOrdersDTO, UpdateOrdersDTO>, IOrdersService
    {
        private readonly IOrders _orders;
        public OrdersService(IOrders orders, IMapper mapper) : base(orders, mapper)
        {
            _orders = orders;
        }
    }
}