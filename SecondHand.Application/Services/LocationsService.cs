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
    public class LocationsService : ILocationsService
    {
        private readonly ILocations _locations;
        private readonly IMapper _mapper;
        public LocationsService(ILocations locations, IMapper mapper)
        {
            _locations = locations;
            _mapper = mapper;
        }

        public Task<Locations> CreateOne(LocationsCreateDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteOneById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Locations>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Locations> GetOneById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Locations> UpdateOneById(Guid id, LocationsUpdateDTO updated)
        {
            throw new NotImplementedException();
        }
    }
}