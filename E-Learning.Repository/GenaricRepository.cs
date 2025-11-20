namespace E_Learning.Repository
{
    public class GenaricRepository<T> : IGenaricRepository<T> where T : BaseEntity
    {
        private readonly StoreContext _DbContext;

        public GenaricRepository(StoreContext dbContext)
        {
            _DbContext = dbContext;
        }


        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _DbContext.Set<T>().ToListAsync();
        }

        public async Task<T?> GetAsync(int id)
        {
            return await _DbContext.Set<T>().FindAsync(id);
        }

        public async Task Add(T entity)
        {
           await _DbContext.Set<T>().AddAsync(entity);
           _DbContext.SaveChanges();
        }
        public void Update(T entity)
        {
            _DbContext.Set<T>().Update(entity);
            _DbContext.SaveChanges();
        }
        public void Delete(T entity)
        {
            _DbContext.Set<T>().Remove(entity);
            _DbContext.SaveChanges();
        }
    }
}
