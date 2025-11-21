using System.Collections;

namespace E_Learning.Repository.Data.UntiOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StoreContext _dbContext;

        private Hashtable _repositories;
        public UnitOfWork(StoreContext dbContext)
        {
            _dbContext = dbContext;
            _repositories = new Hashtable();
        }
        public IGenaricRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity
        {
            var type = typeof(TEntity).Name;
            if (!_repositories.ContainsKey(type))
            {
                var repository = new GenaricRepository<TEntity>(_dbContext) as GenaricRepository<BaseEntity>;

                _repositories.Add(type, repository);
            }
            
            return _repositories[type] as IGenaricRepository<TEntity>;

        }

        public async Task<int> CompleteAsync()
            => await _dbContext.SaveChangesAsync();


        public async ValueTask DisposeAsync()
           => await _dbContext.DisposeAsync();


    }
}
