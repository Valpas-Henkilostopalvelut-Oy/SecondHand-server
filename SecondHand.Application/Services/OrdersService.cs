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
    public class OrdersService : IOrdersService
    {
        private readonly IOrders _orders;
        private readonly IMapper _mapper;
        public OrdersService(IOrders orders, IMapper mapper)
        {
            _orders = orders;
            _mapper = mapper;
        }

        public Task<Orders> CreateOne(OrdersCreateDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteOneById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Orders>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Orders> GetOneById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Orders> UpdateOneById(Guid id, OrdersUpdateDTO updated)
        {
            throw new NotImplementedException();
        }
    }
}