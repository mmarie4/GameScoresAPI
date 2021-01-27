
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        public Repository([NotNull] DbContext context)
        {
            Context = context ?? throw new ArgumentNullException(nameof(context));
        }

        protected DbContext Context { get; }
        protected DbSet<TEntity> Entities => Context.Set<TEntity>();

        public async Task<int> SaveAsync()
        {
            return await Context.SaveChangesAsync();
        }

        /// <summary>
        /// Get all entities in this repository
        /// </summary>
        /// <param name="limit">(TODO)Max number of entities</param>
        /// <param name="offset">(TODO)First index of entity</param>
        /// <returns>Collection of entities</returns>
        public async Task<ICollection<TEntity>> GetAllAsync(int limit, int offset) {
            return await Entities
                .ToListAsync();
        }

       /// <summary>
       /// Adds an entity in the repository
       /// </summary>
       /// <param name="entity">Entity to add</param>
       /// <returns>The entity added</returns>
        public async Task<TEntity> AddAsync(TEntity entity)
        {
            var result = await Entities.AddAsync(entity);
            return result.Entity;
        }

        /// <summary>
        /// Updates an entity in the repository
        /// </summary>
        /// <param name="entity">The entity to update</param>
        /// <returns>The updated entity</returns>
        public TEntity Update(TEntity entity)
        {
            var result = Entities.Update(entity);
            return result.Entity;
        }

        /// <summary>
        /// Removes an entity from the repository
        /// </summary>
        /// <param name="entity">The entity to remove</param>
        /// <returns>The removed entity</returns>
        public TEntity Remove(TEntity entity)
        {
            var result = Entities.Remove(entity);
            return result.Entity;
        }
    }
}
