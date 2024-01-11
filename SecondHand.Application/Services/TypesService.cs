using AutoMapper;
using SecondHand.Application.Dtos;
using SecondHand.Application.Interfaces;
using SecondHand.Domain.Entities;
using SecondHand.Domain.Interfaces;

namespace SecondHand.Application.Services
{
    public class TypesService : ITypesService
    {
        private readonly ITypes _types;
        private readonly IMapper _mapper;
        public TypesService(ITypes types, IMapper mapper)
        {
            _types = types;
            _mapper = mapper;
        }

        public Task<Types> CreateOne(TypesCreateDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteOneById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Types>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Types> GetOneById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Types> UpdateOneById(Guid id, TypesUpdateDTO updated)
        {
            throw new NotImplementedException();
        }
    }
}