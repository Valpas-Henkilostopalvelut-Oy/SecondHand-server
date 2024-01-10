using AutoMapper;
using SecondHand.Application.Dtos;
using SecondHand.Application.Interfaces;
using SecondHand.Domain.Interfaces;

namespace SecondHand.Application.Services
{
    public class BaseService<T, TReadDto, TCreateDto, TUpdateDto> : IBaseService<T, TReadDto, TCreateDto, TUpdateDto>

    {
        private readonly IBaseEntity<T> _baseEntity;
        protected readonly IMapper _mapper;
        public BaseService(IBaseEntity<T> baseEntity, IMapper mapper)
        {
            _baseEntity = baseEntity;
            _mapper = mapper;
        }

        public async Task<bool> DeleteOneById(Guid id)
        {
            var entity = await _baseEntity.GetById(id);
            if (entity == null)
            {
                return default;
            }
            var result = await _baseEntity.SetDeleted(entity);
            var resultMapped = _mapper.Map<ResultDTO>(result);
            return resultMapped != null;
        }

        public async Task<IEnumerable<TReadDto>> GetAll()
        {
            var result = await _baseEntity.GetAll();
            return _mapper.Map<IEnumerable<TReadDto>>(result);
        }

        public async Task<TReadDto> GetOneById(Guid id)
        {
            var result = await _baseEntity.GetById(id);
            return _mapper.Map<TReadDto>(result);
        }

        public async Task<TReadDto> UpdateOneById(Guid id, TUpdateDto entity)
        {
            var entityToUpdate = await _baseEntity.GetById(id);
            if (entityToUpdate == null)
            {
                return default;
            }
            var result = await _baseEntity.Update(entityToUpdate, _mapper.Map<T>(entity));
            return _mapper.Map<TReadDto>(result);
        }

        public async Task<TReadDto> CreateOne(TCreateDto dto)
        {
            var entity = _mapper.Map<T>(dto);
            var result = await _baseEntity.Create(entity);
            return _mapper.Map<TReadDto>(result);
        }
    }
}