using AutoMapper;
using SecondHand.Application.Dtos;
using SecondHand.Application.Interfaces;
using SecondHand.Domain.Interfaces;

namespace SecondHand.Application.Services
{
    public class BaseServices<T, TCreateDto, TUpdateDto> : IBaseServices<T, TCreateDto, TUpdateDto, ResultDTO>

    {
        private readonly IBaseEntity<T> _baseEntity;
        protected readonly IMapper _mapper;
        public BaseServices(IBaseEntity<T> baseEntity, IMapper mapper)
        {
            _baseEntity = baseEntity;
            _mapper = mapper;
        }
        public async Task<T> CreateAsync(TCreateDto entity)
        {
            var entityMapped = _mapper.Map<T>(entity);
            var result = await _baseEntity.Create(entityMapped);
            return result;
        }

        public async Task<ResultDTO> DeleteAsync(Guid id)
        {
            var entity = await _baseEntity.GetById(id);
            if (entity == null)
            {
                return default;
            }
            var result = await _baseEntity.Delete(entity);
            var resultMapped = _mapper.Map<ResultDTO>(result);
            return resultMapped;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var result = await _baseEntity.GetAll();
            return result;
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            var result = await _baseEntity.GetById(id);
            return result;
        }

        public async Task<T> UpdateAsync(Guid id, TUpdateDto entity)
        {
            var entityMapped = _mapper.Map<T>(entity);
            var result = await _baseEntity.Update(entityMapped);
            return result;
        }
    }
}