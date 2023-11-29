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
    public class LocationService : BaseService<Locations, CreateLocationsDTO, UpdateLocationsDTO>, ILocationsService
    {
        private readonly ILocations _locations;
        private readonly IBusinesses _businesses;
        public LocationService(ILocations locations, IBusinesses businesses, IMapper mapper) : base(locations, mapper)
        {
            _locations = locations;
            _businesses = businesses;
        }

        public async Task<IEnumerable<Businesses>> GetBusinessesOnLocationAsync(Guid locationId)
        {
            var location = await _locations.GetById(locationId);
            if (location == null)
            {
                throw new Exception("Location not found");
            }
            var businesses = await _businesses.GetAll();
            return businesses.Where(x => x.Locations != null && x.Locations.Any(b => b.Id == locationId));
        }

        public async Task<ResultDTO> SetBusinessOnLocationAsync(Guid locationId, Guid businessId)
        {
            var location = await _locations.GetById(locationId);
            if (location == null)
            {
                throw new Exception("Location not found");
            }
            var business = await _businesses.GetById(businessId);
            if (business == null)
            {
                throw new Exception("Business not found");
            }
            location.Business = business;
            var result = await _locations.Update(location);
            var resultMapped = _mapper.Map<ResultDTO>(result);
            return resultMapped;
        }
    }
}