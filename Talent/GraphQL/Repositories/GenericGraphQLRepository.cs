using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess;

namespace TalentLogic.GraphQL.Repositories
{
    // ReSharper disable once InconsistentNaming
    public class GenericGraphQLRepository<TModel, TKey> : IGenericGraphQLRepository<TModel, TKey> where TModel : class
    {
        private readonly TalentDbContext _context;
        private readonly DbSet<TModel> _dbSet;

        public GenericGraphQLRepository(TalentDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TModel>();
        }

        public async Task<TModel> Insert(TModel entity)
        {
            _dbSet.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<TModel> Update(TModel entity, TKey id)
        {
            var entityDb = await GetById(id);
            _dbSet.Entry(entityDb).CurrentValues.SetValues(entity);
            await _context.SaveChangesAsync();
            return entityDb;
        }

        public async Task<IEnumerable<TModel>> AddRange(IEnumerable<TModel> entities)
        {
            _dbSet.AddRange(entities);
            await _context.SaveChangesAsync();
            return entities;
        }

        public IQueryable<TModel> Queryable()
        {
            return _dbSet;
        }

        public async Task<IEnumerable<TModel>> Find(Expression<Func<TModel, bool>> expression)
        {
            return await _dbSet.Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<TModel>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<TModel> GetById(TKey id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<bool> Delete(TKey id)
        {
            var entity = await GetById(id);
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteRange(IEnumerable<TModel> entities)
        {
            _dbSet.RemoveRange(entities);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
