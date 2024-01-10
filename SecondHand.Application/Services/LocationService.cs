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
    public class LocationService : BaseService<Locations, LocationsReadDTO, LocationsCreateDTO, LocationsUpdateDTO>, ILocationsService
    {
        public LocationService(IBaseEntity<Locations> baseEntity, IMapper mapper) : base(baseEntity, mapper)
        {
        }
    }
}