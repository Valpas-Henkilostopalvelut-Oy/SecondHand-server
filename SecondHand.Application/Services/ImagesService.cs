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
    public class ImagesService : BaseService<Images, CreateImagesDTO, UpdateImagesDTO>, IImagesService
    {
        private readonly IImages _baseEntity;
        public ImagesService(IImages baseEntity, IMapper mapper) : base(baseEntity, mapper)
        {
            _baseEntity = baseEntity;
        }
    }
}