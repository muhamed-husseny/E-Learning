namespace E_Learning.Core.Repositories.Contract
{
    public interface IGenaricRepository<T> where T : BaseEntity
    {
        Task<T> GetAsync(int id);
        Task<IReadOnlyList<T>> GetAllAsync();
        Task Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
