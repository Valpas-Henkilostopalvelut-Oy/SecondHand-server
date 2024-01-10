namespace SecondHand.Domain.Interfaces
{
    public interface IBaseEntity<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T?> GetById(Guid id);
        Task<T> Update(T updatedEntity, T entity);
        Task<bool> SetDeleted(T entity);
        Task<T> Create(T entity);
    }
}