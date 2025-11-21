namespace E_Learning.Repository.Data.UntiOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StoreContext _dbContext;

        // private Dictionary<string, GenaricRepository<BaseEntity>> _repositories;
        public UnitOfWork(StoreContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IGenaricRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity
        {
            throw new NotImplementedException();
        }

        public Task<int> CompleteAsync()
        {
            throw new NotImplementedException();
        }

     
        public ValueTask DisposeAsync()
        {
            throw new NotImplementedException();
        }

        
    }
}
