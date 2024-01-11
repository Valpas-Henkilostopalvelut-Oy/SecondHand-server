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
    public class ImagesService : IImagesService
    {
        private readonly IImages _images;
        private readonly IMapper _mapper;
        public ImagesService(IImages images, IMapper mapper)
        {
            _images = images;
            _mapper = mapper;
        }

        public Task<Images> CreateOne(ImagesCreateDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteOneById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Images>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Images> GetOneById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Images> UpdateOneById(Guid id, ImagesUpdateDTO updated)
        {
            throw new NotImplementedException();
        }
    }
}