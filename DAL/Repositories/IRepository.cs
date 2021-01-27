using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface IRepository<TEntity> where TEntity: class
    {
        Task<int> SaveAsync();
        Task<ICollection<TEntity>> GetAllAsync(int offset, int limit);
        Task<TEntity> AddAsync(TEntity entity);
        TEntity Update(TEntity entity);
        TEntity Remove(TEntity entity);
    }
}
    