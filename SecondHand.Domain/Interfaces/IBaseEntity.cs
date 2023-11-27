namespace SecondHand.Domain.Interfaces
{
    public interface IBaseEntity<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T?> GetById(Guid id);
        Task<T> Update(T updatedEntity);
        Task<bool> Delete(T entity);
        Task<T> Create(T entity);
    }
}