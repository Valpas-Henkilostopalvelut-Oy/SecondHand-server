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
    public class BusinessesService : BaseService<Businesses, BusinessesReadDTO, BusinessesCreateDTO, BusinessesUpdateDTO>, IBusinessesService
    {
        private readonly IBusinesses _businesses;
        public BusinessesService(IBusinesses businesses, IMapper mapper) : base(businesses, mapper)
        {
            _businesses = businesses;
        }
    }

}
