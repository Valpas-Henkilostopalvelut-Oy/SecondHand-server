namespace SecondHand.Application.Interfaces
{
    public interface IBaseService<T, TReadDto, TCreateDto, TUpdateDto>
    {
        Task<IEnumerable<TReadDto>> GetAll();
        Task<TReadDto> GetOneById(Guid id);
        Task<TReadDto> UpdateOneById(Guid id, TUpdateDto updated);
        Task<bool> DeleteOneById(Guid id);
        Task<TReadDto> CreateOne(TCreateDto dto);
    }
}