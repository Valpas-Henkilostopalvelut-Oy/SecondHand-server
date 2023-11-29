namespace SecondHand.Application.Interfaces
{
    public interface IBaseService<TEntity, TCreateDto, TUpdateDto, ResultDTO>
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(Guid id);
        Task<TEntity> CreateAsync(TCreateDto entity);
        Task<TEntity> UpdateAsync(Guid id, TUpdateDto entity);
        Task<ResultDTO> DeleteAsync(Guid id);
    }
}