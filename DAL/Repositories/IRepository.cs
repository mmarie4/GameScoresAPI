using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public interface IRepository : IDisposable
    {

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        Task<int> GetAll();
    }
}
