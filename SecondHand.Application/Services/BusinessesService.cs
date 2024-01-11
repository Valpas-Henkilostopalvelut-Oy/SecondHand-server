using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using AutoMapper;
using SecondHand.Application.CustomException;
using SecondHand.Application.Dtos;
using SecondHand.Application.Interfaces;
using SecondHand.Domain.Entities;
using SecondHand.Domain.Interfaces;

namespace SecondHand.Application.Services
{
    public class BusinessesService : IBusinessesService
    {
        private readonly IBusinesses _businesses;
        private readonly IMapper _mapper;
        public BusinessesService(IBusinesses businesses, IMapper mapper)
        {
            _businesses = businesses;
            _mapper = mapper;
        }

        public Task<Businesses> CreateOne(BusinessesCreateDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteOneById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Businesses>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Businesses> GetOneById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Businesses> UpdateOneById(Guid id, BusinessesUpdateDTO updated)
        {
            throw new NotImplementedException();
        }
    }

}
