namespace SecondHand.Domain.Interfaces
{
    public interface IBaseEntity<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T?> GetById(Guid id);
        Task<T> Update(Guid id, T updatedEntity);
        Task<T> Create(T entity);
    }
}