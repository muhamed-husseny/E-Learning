using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Learning.Core.Repositories.Contract
{
    public interface IGenaricRepository<T> where T : class
    {
        Task<T> GetAsync(int id);
        Task<IReadOnlyList<T>> GetAllAsync();
        Task Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
