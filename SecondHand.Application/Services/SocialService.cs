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
    public class SocialService : BaseService<Socials, CreateSocialsDTO, UpdateSocialsDTO>, ISocialService
    {
        private readonly ISocials _socials;
        private readonly IBusinesses _businesses;
        public SocialService(ISocials socials, IMapper mapper, IBusinesses businesses) : base(socials, mapper)
        {
            _socials = socials;
            _businesses = businesses;
        }
        // Set social to business
        public async Task<ResultDTO> SetSocialToBusiness(CreateSocialsDTO socialsDTO)
        {
            var business = await _businesses.GetById(socialsDTO.BusinessId);
            if (business == null)
            {
                throw new Exception("Business not found");
            }
            var socials = _mapper.Map<Socials>(socialsDTO);
            business.Socials = socials;
            var result = await _businesses.Update(business);
            var resultMapped = _mapper.Map<ResultDTO>(result);
            return resultMapped;
        }
        // Get social by business id
        public async Task<Socials> GetSocialByBusinessId(Guid businessId)
        {
            var business = await _businesses.GetById(businessId);
            if (business == null)
            {
                throw new Exception("Business not found");
            }
            return business.Socials!;
        }
    }
}