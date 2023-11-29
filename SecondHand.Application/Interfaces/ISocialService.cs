using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SecondHand.Application.Dtos;
using SecondHand.Domain.Entities;

namespace SecondHand.Application.Interfaces
{
    public interface ISocialService : IBaseService<Socials, CreateSocialsDTO, UpdateSocialsDTO, ResultDTO>
    {
        // Set social to business
        Task<ResultDTO> SetSocialToBusiness(CreateSocialsDTO socialsDTO);
        // Get social by business id
        Task<Socials> GetSocialByBusinessId(Guid businessId);

    }
}