namespace SecondHand.Application.Interfaces
{
    public interface IBaseRepo<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T?> GetOneById(Guid id);
        Task<T> UpdateOne(T updatedEntity);
        Task<bool> DeleteOneById(T entity);
        Task<T> CreateOne(T entity);
    }
}