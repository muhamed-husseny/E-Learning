namespace E_Learning.Core.UnitOfWork
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IGenaricRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity;

        Task<int> CompleteAsync();
    }
}
