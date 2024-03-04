using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        void Update(T entity);
        Task RemoveAsync(T entity);
    }
}