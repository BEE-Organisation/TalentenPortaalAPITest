using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentDataAccess.DataAccess.DataAccessObjects;

namespace TalentDataAccess.DataAccess.Repositories
{

    public interface ITalentPropertyRepository
    {
        Task Create(TalentPropertyMainCategoryLink entity);

        Task CreateRange(List<TalentPropertyMainCategoryLink> entities);

        Task<List<TalentPropertyMainCategoryLink>> GetAll();

        Task<TalentPropertyMainCategoryLink> GetByTalentIdAndPropertyId(int talentId, int propertyId);

        Task<List<TalentPropertyMainCategoryLink>> GetAllByTalentId(int talentId);

        Task<List<TalentPropertyLabel>> GetAllLabels();

        Task<List<TalentPropertyLabel>> GetLabelsByIds(List<int> ids);

        Task<int> CreateLabel(TalentPropertyLabel label);
        Task RemoveMainCategoryByIds(List<int> ids);

        Task RemoveSubCategoryByIds(List<int> ids);

    }

    public class TalentPropertyRepository: ITalentPropertyRepository
    {
        private readonly TalentDbContext _dbContext;

        public TalentPropertyRepository(TalentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(TalentPropertyMainCategoryLink entity)
        {
            await _dbContext.TalentPropertyMainCategoryLinks.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<int> CreateLabel(TalentPropertyLabel label)
        {
            await _dbContext.TalentPropertyLabels.AddAsync(label);
            await _dbContext.SaveChangesAsync();

            return label.Id;
        }

        public async Task CreateRange(List<TalentPropertyMainCategoryLink> entities)
        {
            await _dbContext.TalentPropertyMainCategoryLinks.AddRangeAsync(entities);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<TalentPropertyMainCategoryLink>> GetAll()
        {
            return await _dbContext.TalentPropertyMainCategoryLinks
                .AsNoTracking()
                .Include(x => x.TalentPropertySubCategoryLinks.OrderBy(x => x.Order))
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public async Task<List<TalentPropertyLabel>> GetAllLabels()
        {
            return await _dbContext.TalentPropertyLabels
                .AsNoTracking()
                .ToListAsync()
                .ConfigureAwait(false);
        }


        public async Task<List<TalentPropertyLabel>> GetLabelsByIds(List<int> ids)
        {
            return await _dbContext.TalentPropertyLabels
                .AsNoTracking()
                .Where(x => ids.Contains(x.Id))
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public async Task<TalentPropertyMainCategoryLink> GetByTalentIdAndPropertyId(int talentId, int propertyId)
        {
            return await _dbContext.TalentPropertyMainCategoryLinks
                .AsNoTracking()
                .Include(x => x.TalentPropertySubCategoryLinks.OrderBy(x => x.Order))
                .SingleOrDefaultAsync(x => x.TalentId == talentId && x.TalentPropertyLabelId == propertyId)
                .ConfigureAwait(false) ?? new TalentPropertyMainCategoryLink();
        }

        public async Task<List<TalentPropertyMainCategoryLink>> GetAllByTalentId(int talentId)
        {
            return await _dbContext.TalentPropertyMainCategoryLinks
                .AsNoTracking()
                .Include(x => x.TalentPropertySubCategoryLinks.OrderBy(x => x.Order))
                .Where(x => x.TalentId == talentId)
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public async Task RemoveMainCategoryByIds(List<int> ids)
        {
            var records = await _dbContext.TalentPropertyMainCategoryLinks
                .AsNoTracking()
                .Where(x => ids.Contains(x.Id))
                .ToListAsync()
                .ConfigureAwait(false);

            if (records != null)
            {
                _dbContext.TalentPropertyMainCategoryLinks.RemoveRange(records);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task RemoveSubCategoryByIds(List<int> ids)
        {
            var records = await _dbContext.TalentPropertySubCategoryLinks
                .AsNoTracking()
                .Where(x => ids.Contains(x.Id))
                .ToListAsync()
                .ConfigureAwait(false);

            if (records != null)
            {
                _dbContext.TalentPropertySubCategoryLinks.RemoveRange(records);
                await _dbContext.SaveChangesAsync();
            }
        }


    }

}
