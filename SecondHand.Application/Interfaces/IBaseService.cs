namespace SecondHand.Application.Interfaces
{
    public interface IBaseService<T, TCreateDto, TUpdateDto>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetOneById(Guid id);
        Task<T> UpdateOneById(Guid id, TUpdateDto updated);
        Task<bool> DeleteOneById(Guid id);
        Task<T> CreateOne(TCreateDto dto);
    }
}