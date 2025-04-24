using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess.DataAccessObjects;

namespace TalentDataAccess.DataAccess.Repositories
{

    public interface ITalentPropertyLabelRepository
    {

        Task Create(TalentPropertyLabel entity);

        Task Update(TalentPropertyLabel entity);

        Task Delete(int id);

        Task<List<TalentPropertyLabel>> GetAll();

        Task<TalentPropertyLabel?> GetById(int id);

        Task<List<TalentPropertyLabel>> GetByIds(List<int> ids);

        Task<int> CountLabels(bool isNull);
    }

    public class TalentPropertyLabelRepository : ITalentPropertyLabelRepository
    {
        private readonly TalentDbContext _dbContext;

        public TalentPropertyLabelRepository(TalentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> CountLabels(bool isNull)
        {
            if(isNull)
            {
                return await _dbContext.TalentPropertyLabels
                    .Where(x => x.ParentId == null)
                    .Select(x => x.Id)
                    .CountAsync()
                    .ConfigureAwait(false);
            }
            else
            {
                return await _dbContext.TalentPropertyLabels
                    .Where(x => x.ParentId != null)
                    .Select(x => x.Id)
                    .CountAsync()
                    .ConfigureAwait(false);
            }
        }

        public async Task Create(TalentPropertyLabel entity)
        {
            await _dbContext.TalentPropertyLabels.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var record = await GetById(id);

            if(record != null)
            {
                if(record.ParentId == null)
                {
                    var items = await _dbContext.TalentPropertyLabels.AsNoTracking().Where(x => x.ParentId == id).ToListAsync().ConfigureAwait(false);

                    if (items != null)
                    {
                        _dbContext.TalentPropertyLabels.RemoveRange(items);
                    }                    
                }

                _dbContext.TalentPropertyLabels.Remove(record);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<List<TalentPropertyLabel>> GetAll()
        {
            return await _dbContext.TalentPropertyLabels.ToListAsync().ConfigureAwait(false);
        }

        public async Task<TalentPropertyLabel?> GetById(int id)
        {
            return await _dbContext.TalentPropertyLabels
                .AsNoTracking()
                .SingleOrDefaultAsync(x => x.Id == id)
                .ConfigureAwait(false);
        }

        public async Task<List<TalentPropertyLabel>> GetByIds(List<int> ids)
        {
            return await _dbContext.TalentPropertyLabels
                .AsNoTracking()
                .Where(x => ids.Contains(x.Id))
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public async Task Update(TalentPropertyLabel entity)
        {
            _dbContext.TalentPropertyLabels.Update(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
