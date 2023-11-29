using AutoMapper;
using SecondHand.Application.Dtos;
using SecondHand.Application.Interfaces;
using SecondHand.Domain.Entities;
using SecondHand.Domain.Interfaces;

namespace SecondHand.Application.Services
{
    public class OpeningHoursService : BaseService<OpeningHours, CreateOpeningHoursDTO, UpdateOpeningHoursDTO>, IOpeningHoursService
    {
        private readonly IOpeningHours _openingHours;
        private readonly IBusinesses _businesses;
        public OpeningHoursService(IOpeningHours openingHours, IMapper mapper, IBusinesses businesses) : base(openingHours, mapper)
        {
            _openingHours = openingHours;
            _businesses = businesses;
        }

        public async Task<IEnumerable<OpeningHours>> GetOpeningHoursOnBusinessAsync(Guid businessId)
        {
            var business = await _businesses.GetById(businessId);
            if (business == null)
            {
                throw new Exception("Business not found");
            }
            return business.OpeningHours!;
        }

        public async Task<ResultDTO> SetOpeningHoursOnBusinessAsync(Guid businessId, Guid openingHoursId)
        {
            var business = await _businesses.GetById(businessId);
            if (business == null)
            {
                throw new Exception("Business not found");
            }
            var openingHours = await _openingHours.GetById(openingHoursId);
            if (openingHours == null)
            {
                throw new Exception("OpeningHours not found");
            }
            business.OpeningHours.Add(openingHours);
            var result = await _businesses.Update(business);
            var resultMapped = _mapper.Map<ResultDTO>(result);
            return resultMapped;
        }
    }
}